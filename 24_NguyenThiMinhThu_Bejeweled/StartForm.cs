using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_NguyenThiMinhThu_Bejeweled
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Bejeweled gameForm = new Bejeweled();
            gameForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.start; 
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
