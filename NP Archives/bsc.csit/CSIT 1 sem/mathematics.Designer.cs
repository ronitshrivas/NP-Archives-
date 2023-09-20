namespace NP_Archives.bsc.csit.CSIT_1_sem
{
    partial class mathematics
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
            tabControl1 = new TabControl();
            textbookpage = new TabPage();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            modelquestionpage = new TabPage();
            button1 = new Button();
            webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabPage1 = new TabPage();
            button2 = new Button();
            webView23 = new Microsoft.Web.WebView2.WinForms.WebView2();
            backbtn = new Button();
            tabControl1.SuspendLayout();
            textbookpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            modelquestionpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView22).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView23).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(textbookpage);
            tabControl1.Controls.Add(modelquestionpage);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(1, 50);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1210, 557);
            tabControl1.TabIndex = 61;
            // 
            // textbookpage
            // 
            textbookpage.BackColor = Color.FromArgb(45, 54, 76);
            textbookpage.Controls.Add(webView21);
            textbookpage.Location = new Point(4, 28);
            textbookpage.Name = "textbookpage";
            textbookpage.Padding = new Padding(3);
            textbookpage.Size = new Size(1202, 525);
            textbookpage.TabIndex = 0;
            textbookpage.Text = "Syllabus";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(3, 3);
            webView21.Name = "webView21";
            webView21.Size = new Size(1196, 519);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // modelquestionpage
            // 
            modelquestionpage.BackColor = Color.FromArgb(45, 54, 76);
            modelquestionpage.Controls.Add(button1);
            modelquestionpage.Controls.Add(webView22);
            modelquestionpage.Location = new Point(4, 28);
            modelquestionpage.Name = "modelquestionpage";
            modelquestionpage.Padding = new Padding(3);
            modelquestionpage.Size = new Size(1202, 525);
            modelquestionpage.TabIndex = 1;
            modelquestionpage.Text = "Hand Written Notes";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(548, 234);
            button1.Name = "button1";
            button1.Size = new Size(120, 46);
            button1.TabIndex = 97;
            button1.Text = "! Download";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // webView22
            // 
            webView22.AllowExternalDrop = true;
            webView22.CreationProperties = null;
            webView22.DefaultBackgroundColor = Color.White;
            webView22.Dock = DockStyle.Fill;
            webView22.Location = new Point(3, 3);
            webView22.Name = "webView22";
            webView22.Size = new Size(1196, 519);
            webView22.TabIndex = 1;
            webView22.ZoomFactor = 1D;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(webView23);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1202, 525);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Exam Question";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(548, 234);
            button2.Name = "button2";
            button2.Size = new Size(120, 46);
            button2.TabIndex = 97;
            button2.Text = "! Download";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // webView23
            // 
            webView23.AllowExternalDrop = true;
            webView23.BackColor = Color.FromArgb(45, 54, 76);
            webView23.CreationProperties = null;
            webView23.DefaultBackgroundColor = Color.White;
            webView23.Dock = DockStyle.Fill;
            webView23.Location = new Point(0, 0);
            webView23.Name = "webView23";
            webView23.Size = new Size(1202, 525);
            webView23.TabIndex = 1;
            webView23.ZoomFactor = 1D;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.FromArgb(45, 54, 76);
            backbtn.FlatAppearance.BorderColor = Color.FromArgb(45, 54, 76);
            backbtn.FlatAppearance.BorderSize = 0;
            backbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 54, 76);
            backbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 54, 76);
            backbtn.FlatStyle = FlatStyle.Flat;
            backbtn.Image = Properties.Resources.back_to_32px;
            backbtn.Location = new Point(5, 7);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(46, 37);
            backbtn.TabIndex = 96;
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // mathematics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 54, 76);
            ClientSize = new Size(1213, 608);
            Controls.Add(backbtn);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mathematics";
            Text = "mathematics";
            Load += mathematics_Load;
            tabControl1.ResumeLayout(false);
            textbookpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            modelquestionpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView22).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView23).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage textbookpage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TabPage modelquestionpage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private Button backbtn;
        private TabPage tabPage1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView23;
        private Button button1;
        private Button button2;
    }
}