namespace NP_Archives
{
    partial class homepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            timer1 = new System.Windows.Forms.Timer(components);
            backgrod = new Panel();
            button6 = new Button();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            btncollegelevel = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            lblinternetconnectioncheck = new Label();
            label2 = new Label();
            label1 = new Label();
            lbldate = new Label();
            lbltimer = new Label();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            backgrod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // backgrod
            // 
            backgrod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backgrod.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backgrod.Controls.Add(button6);
            backgrod.Controls.Add(pictureBox2);
            backgrod.Controls.Add(button1);
            backgrod.Controls.Add(pictureBox4);
            backgrod.Controls.Add(button2);
            backgrod.Controls.Add(pictureBox3);
            backgrod.Controls.Add(btncollegelevel);
            backgrod.Controls.Add(pictureBox1);
            backgrod.Controls.Add(label3);
            backgrod.Controls.Add(lblinternetconnectioncheck);
            backgrod.Controls.Add(label2);
            backgrod.Controls.Add(label1);
            backgrod.Controls.Add(lbldate);
            backgrod.Controls.Add(lbltimer);
            backgrod.Location = new Point(3, 49);
            backgrod.Name = "backgrod";
            backgrod.Size = new Size(1223, 616);
            backgrod.TabIndex = 7;
            backgrod.Paint += backgrod_Paint;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.AutoSize = true;
            button6.BackColor = Color.Lime;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(57, 519);
            button6.Name = "button6";
            button6.Size = new Size(186, 50);
            button6.TabIndex = 30;
            button6.TabStop = false;
            button6.Text = "School Level";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            button6.Paint += button6_Paint_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources.loginn;
            pictureBox2.Location = new Point(31, 354);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(238, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(944, 519);
            button1.Name = "button1";
            button1.Size = new Size(235, 50);
            button1.TabIndex = 28;
            button1.TabStop = false;
            button1.Text = "Hacking / Programming";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox4.Image = Properties.Resources.kindpng_7041009;
            pictureBox4.Location = new Point(941, 354);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(238, 159);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.Lime;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(668, 519);
            button2.Name = "button2";
            button2.Size = new Size(186, 50);
            button2.TabIndex = 26;
            button2.TabStop = false;
            button2.Text = "Bachelor's Level";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.bachelorlvl;
            pictureBox3.Location = new Point(640, 354);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(238, 159);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // btncollegelevel
            // 
            btncollegelevel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btncollegelevel.AutoSize = true;
            btncollegelevel.BackColor = Color.Lime;
            btncollegelevel.FlatStyle = FlatStyle.Flat;
            btncollegelevel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btncollegelevel.ForeColor = Color.White;
            btncollegelevel.Location = new Point(338, 519);
            btncollegelevel.Name = "btncollegelevel";
            btncollegelevel.Size = new Size(198, 50);
            btncollegelevel.TabIndex = 24;
            btncollegelevel.TabStop = false;
            btncollegelevel.Text = "+2 Level";
            btncollegelevel.UseVisualStyleBackColor = false;
            btncollegelevel.Click += btncollegelevel_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.collegelogin;
            pictureBox1.Location = new Point(325, 354);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(5, 585);
            label3.Name = "label3";
            label3.Size = new Size(139, 21);
            label3.TabIndex = 19;
            label3.Text = "© copyright 2023";
            // 
            // lblinternetconnectioncheck
            // 
            lblinternetconnectioncheck.Anchor = AnchorStyles.Left;
            lblinternetconnectioncheck.AutoSize = true;
            lblinternetconnectioncheck.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblinternetconnectioncheck.ForeColor = Color.White;
            lblinternetconnectioncheck.Location = new Point(571, 246);
            lblinternetconnectioncheck.Name = "lblinternetconnectioncheck";
            lblinternetconnectioncheck.Size = new Size(0, 25);
            lblinternetconnectioncheck.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(489, 246);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 15;
            label2.Text = "Status : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 37);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 14;
            label1.Text = "NI Tutor";
            // 
            // lbldate
            // 
            lbldate.Anchor = AnchorStyles.Left;
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbldate.ForeColor = Color.White;
            lbldate.Location = new Point(33, 283);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(49, 25);
            lbldate.TabIndex = 13;
            lbldate.Text = "date";
            // 
            // lbltimer
            // 
            lbltimer.Anchor = AnchorStyles.Left;
            lbltimer.AutoSize = true;
            lbltimer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbltimer.ForeColor = Color.White;
            lbltimer.Location = new Point(33, 246);
            lbltimer.Name = "lbltimer";
            lbltimer.Size = new Size(49, 25);
            lbltimer.TabIndex = 12;
            lbltimer.Text = "time";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(45, 54, 76);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(45, 54, 76);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 54, 76);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 54, 76);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1117, -1);
            button4.Name = "button4";
            button4.Size = new Size(36, 39);
            button4.TabIndex = 1;
            button4.TabStop = false;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(45, 54, 76);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(45, 54, 76);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 54, 76);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 54, 76);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1184, 4);
            button3.Name = "button3";
            button3.Size = new Size(40, 39);
            button3.TabIndex = 0;
            button3.TabStop = false;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(45, 54, 76);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.FromArgb(45, 54, 76);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 54, 76);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 54, 76);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.maximize_window_32px;
            button5.Location = new Point(1145, 4);
            button5.Name = "button5";
            button5.Size = new Size(44, 39);
            button5.TabIndex = 2;
            button5.TabStop = false;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1223, 52);
            panel1.TabIndex = 32;
            panel1.MouseDown += panel1_MouseDown_1;
            panel1.MouseMove += panel1_MouseMove_1;
            panel1.MouseUp += panel1_MouseUp_1;
            // 
            // homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(45, 54, 76);
            ClientSize = new Size(1227, 667);
            Controls.Add(panel1);
            Controls.Add(backgrod);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Load += homepage_Load;
            Resize += homepage_Resize;
            backgrod.ResumeLayout(false);
            backgrod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Panel backgrod;
        private Button button6;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pictureBox4;
        private Button button2;
        private PictureBox pictureBox3;
        private Button btncollegelevel;
        private PictureBox pictureBox1;
        private Label label3;
        private Label lblinternetconnectioncheck;
        private Label label2;
        private Label label1;
        private Label lbldate;
        private Label lbltimer;
        private Button button4;
        private Button button3;
        private Button button5;
        private Panel panel1;
    }
}