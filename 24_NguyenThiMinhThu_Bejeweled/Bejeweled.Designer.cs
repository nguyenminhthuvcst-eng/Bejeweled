namespace _24_NguyenThiMinhThu_Bejeweled
{
    partial class Bejeweled
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bejeweled));
            this.panelGrid = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timerMatch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelGrid.Location = new System.Drawing.Point(41, 20);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(428, 389);
            this.panelGrid.TabIndex = 0;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblScore.Location = new System.Drawing.Point(688, 453);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(86, 25);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(847, 453);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 25);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblScoreValue.Location = new System.Drawing.Point(484, 275);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(86, 25);
            this.lblScoreValue.TabIndex = 3;
            this.lblScoreValue.Text = "Điểm: 0";
            this.lblScoreValue.Click += new System.EventHandler(this.lblScore_Click);
            this.lblScoreValue.DoubleClick += new System.EventHandler(this.lblScore_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(472, 310);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(139, 25);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Thời gian: 60";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // btnExit1
            // 
            this.btnExit1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit1.Location = new System.Drawing.Point(618, 357);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(92, 27);
            this.btnExit1.TabIndex = 5;
            this.btnExit1.Text = "Exit";
            this.btnExit1.UseVisualStyleBackColor = false;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(489, 357);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(92, 28);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Bejeweled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 433);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnExit1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panelGrid);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Bejeweled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejeweled";
            this.Load += new System.EventHandler(this.Bejeweled_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer timerMatch;
    }
}
