using _24_NguyenThiMinhThu_Bejeweled.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;


namespace _24_NguyenThiMinhThu_Bejeweled
{

    public partial class Bejeweled : Form
    {
        const int GridSize = 8;
        const int TileSize = 40;

        class Piece
        {
            public int Row, Col;
            public int Kind;
            public PictureBox Box;
        }

        Piece[,] grid = new Piece[GridSize, GridSize];
        Piece selected = null;
        Random rand = new Random();
        int score = 0;
        int timeLeft = 60;

        PictureBox cursorImage; 
        public Bejeweled()
        {
            InitializeComponent();
            this.Load += Bejeweled_Load;

        }
        private void Bejeweled_Load(object sender, EventArgs e)
        {
            cursorImage = new PictureBox();
            cursorImage.Size = new Size(TileSize, TileSize);
            cursorImage.BackColor = Color.Transparent;
            cursorImage.SizeMode = PictureBoxSizeMode.StretchImage;
            cursorImage.BorderStyle = BorderStyle.None;
            cursorImage.Image = Properties.Resources.cursor;
            cursorImage.Visible = false;
            gameTimer.Interval = 1000; // mỗi 1 giây
            gameTimer.Tick += gameTimer_Tick;
            gameTimer.Start();

            CreateGrid();

            panelGrid.Controls.Add(cursorImage);
            cursorImage.BringToFront();
            lblScore.Text = "Điểm: 0";
            lblTime.Text = "Thời gian: 60";
        }
        void CreateGrid()
        {
            {
                var gemBoxes = panelGrid.Controls.OfType<PictureBox>()
                                    .Where(pb => pb.Tag != null && pb.Tag is Piece) // Chỉ xóa gem
                                    .ToList();

                foreach (var box in gemBoxes)
                {
                    panelGrid.Controls.Remove(box);
                }
                for (int row = 0; row < GridSize; row++)
                {
                    for (int col = 0; col < GridSize; col++)
                    {
                        Piece p = new Piece();
                        p.Row = row;
                        p.Col = col;

                        // Tránh tạo >3 viên giống nhau
                        int kind;
                        do
                        {
                            kind = rand.Next(7);
                        }
                        while (
                            (col >= 2 &&
                             grid[row, col - 1].Kind == kind &&
                             grid[row, col - 2].Kind == kind) ||
                            (row >= 2 &&
                             grid[row - 1, col].Kind == kind &&
                             grid[row - 2, col].Kind == kind)
                        );

                        p.Kind = kind;

                        p.Box = new PictureBox();
                        p.Box.Size = new Size(TileSize, TileSize);
                        p.Box.Location = new Point(col * TileSize, row * TileSize);
                        p.Box.Image = GetGemImage(p.Kind);
                        p.Box.SizeMode = PictureBoxSizeMode.StretchImage;
                        p.Box.Tag = p; // Gắn tag để phân biệt với cursor
                        p.Box.Click += Box_Click;

                        panelGrid.Controls.Add(p.Box);
                        grid[row, col] = p;
                    }
                }
                if (!panelGrid.Controls.Contains(cursorImage))
                {
                    panelGrid.Controls.Add(cursorImage);
                }
                cursorImage.BringToFront(); // <- Đưa con trỏ lên trên cùng
                cursorImage.Visible = false;
            }
        }
        Image GetGemImage(int kind)
        {
            switch (kind)
            {
                case 0: return Properties.Resources.gem1;
                case 1: return Properties.Resources.gem2;
                case 2: return Properties.Resources.gem3;
                case 3: return Properties.Resources.gem4;
                case 4: return Properties.Resources.gem5;
                case 5: return Properties.Resources.gem6;
                case 6: return Properties.Resources.gem7;
                default: return null;
            }
        }
        void Box_Click(object sender, EventArgs e)
        {
            PictureBox clicked = sender as PictureBox;
            Piece p = (Piece)clicked.Tag;

            if (selected == null)
            {
                selected = p;
                selected.Box.BorderStyle = BorderStyle.Fixed3D;

                // Hiển thị con trỏ tại vị trí đã chọn
                cursorImage.Location = selected.Box.Location;
                cursorImage.Visible = true;
                cursorImage.BringToFront();
                return;
            }

            // Nếu chọn lại chính ô đó thì bỏ chọn
            if (selected == p)
            {
                selected.Box.BorderStyle = BorderStyle.None;
                selected = null;
                cursorImage.Visible = false;
                return;
            }

            // Kiểm tra có liền kề không
            if ((Math.Abs(selected.Row - p.Row) == 1 && selected.Col == p.Col) ||
                (Math.Abs(selected.Col - p.Col) == 1 && selected.Row == p.Row))
            {
                SwapPieces(selected, p);

                this.BeginInvoke((Action)(() =>
                {
                    if (!CheckMatches())
                    {
                        SwapPieces(selected, p); // Đổi lại nếu không khớp
                    }
                    else
                    {
                        CollapseGrid(); // Xử lý rớt gem
                    }

                    // Sau khi xử lý xong, ẩn con trỏ và bỏ chọn
                    if (selected != null)
                        selected.Box.BorderStyle = BorderStyle.None;

                    selected = null;
                    cursorImage.Visible = false;
                }));
            }
            else
            {
                // Nếu không liền kề, chuyển vùng chọn
                selected.Box.BorderStyle = BorderStyle.None;
                selected = p;
                selected.Box.BorderStyle = BorderStyle.Fixed3D;
                cursorImage.Location = selected.Box.Location;
                cursorImage.Visible = true;
                cursorImage.BringToFront();
            }
        }
        void SwapPieces(Piece a, Piece b)
        {
            int temp = a.Kind;
            a.Kind = b.Kind;
            b.Kind = temp;

            a.Box.Image = GetGemImage(a.Kind);
            b.Box.Image = GetGemImage(b.Kind);
        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }
        bool CheckMatches()
        {
            bool found = false;
            List<Piece> matches = new List<Piece>();

            // Kiểm tra hàng ngang
            for (int row = 0; row < GridSize; row++)
            {
                for (int col = 0; col < GridSize - 2; col++)
                {
                    int kind = grid[row, col].Kind;
                    if (kind != -1 &&
                        kind == grid[row, col + 1].Kind &&
                        kind == grid[row, col + 2].Kind)
                    {
                        matches.Add(grid[row, col]);
                        matches.Add(grid[row, col + 1]);
                        matches.Add(grid[row, col + 2]);
                        found = true;
                    }
                }
            }
            // Kiểm tra hàng dọc
            for (int col = 0; col < GridSize; col++)
            {
                for (int row = 0; row < GridSize - 2; row++)
                {
                    int kind = grid[row, col].Kind;
                    if (kind != -1 &&
                        kind == grid[row + 1, col].Kind &&
                        kind == grid[row + 2, col].Kind)
                    {
                        matches.Add(grid[row, col]);
                        matches.Add(grid[row + 1, col]);
                        matches.Add(grid[row + 2, col]);
                        found = true;
                    }
                }
            }
            foreach (var p in matches.Distinct())
            {
                Console.WriteLine($"Xóa gem ở ({p.Row},{p.Col}) loại {p.Kind}");
                p.Kind = -1;
                p.Box.Image = null;
            }

            score += matches.Count * 10;
            if (lblScoreValue != null)
                lblScoreValue.Text = "Điểm: " + score;

            return found;
        }
        void CollapseGrid()
        {
            for (int col = 0; col < GridSize; col++)
            {
                int writeRow = GridSize - 1;

                for (int row = GridSize - 1; row >= 0; row--)
                {
                    if (grid[row, col].Kind != -1)
                    {
                        if (writeRow != row)
                        {
                            grid[writeRow, col].Kind = grid[row, col].Kind;
                            grid[writeRow, col].Box.Image = GetGemImage(grid[row, col].Kind);
                        }
                        writeRow--;
                    }
                }
                for (int row = writeRow; row >= 0; row--)
                {
                    int newKind = rand.Next(7);
                    grid[row, col].Kind = newKind;
                    grid[row, col].Box.Image = GetGemImage(newKind);
                }
            }
            if (CheckMatches())
                CollapseGrid();
        }
        private void lblScore_Click(object sender, EventArgs e)
        {

            if (lblScore != null)
                lblScore.Text = "Điểm: " + score;
        }
        private void lblTime_Click(object sender, EventArgs e)
        {

        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            var gemBoxes = panelGrid.Controls.OfType<PictureBox>()
                                .Where(pb => pb != cursorImage && pb.Tag is Piece)
                                .ToList();
            foreach (var box in gemBoxes)
            {
                panelGrid.Controls.Remove(box);
            }
            score = 0;
            timeLeft = 60;
            lblScoreValue.Text = "Điểm: 0";
            lblTime.Text = "Thời gian: 60";

            CreateGrid();
            gameTimer.Start();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTime.Text = "Thời gian: " + timeLeft;
            }
            else
            {
                gameTimer.Stop();
                MessageBox.Show("Hết giờ! Tổng điểm: " + score);
            }
        }
    }
}
