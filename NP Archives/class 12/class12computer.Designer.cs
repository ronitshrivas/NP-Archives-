namespace NP_Archives.class_12
{
    partial class class12computer
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
            modelquestionpage = new TabPage();
            button2 = new Button();
            webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            textbookpage = new TabPage();
            button1 = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabControl1 = new TabControl();
            backbtn = new Button();
            label1 = new Label();
            modelquestionpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView22).BeginInit();
            textbookpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // modelquestionpage
            // 
            modelquestionpage.BackColor = Color.FromArgb(45, 54, 76);
            modelquestionpage.Controls.Add(button2);
            modelquestionpage.Controls.Add(webView22);
            modelquestionpage.Location = new Point(4, 28);
            modelquestionpage.Name = "modelquestionpage";
            modelquestionpage.Padding = new Padding(3);
            modelquestionpage.Size = new Size(1202, 525);
            modelquestionpage.TabIndex = 1;
            modelquestionpage.Text = "Model Question";
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
            button2.TabIndex = 77;
            button2.Text = "! Download";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            // textbookpage
            // 
            textbookpage.BackColor = Color.FromArgb(45, 54, 76);
            textbookpage.Controls.Add(button1);
            textbookpage.Controls.Add(webView21);
            textbookpage.Location = new Point(4, 28);
            textbookpage.Name = "textbookpage";
            textbookpage.Padding = new Padding(3);
            textbookpage.Size = new Size(1202, 525);
            textbookpage.TabIndex = 0;
            textbookpage.Text = "Text Book";
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
            button1.TabIndex = 77;
            button1.Text = "! Download";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(textbookpage);
            tabControl1.Controls.Add(modelquestionpage);
            tabControl1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(1, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1210, 557);
            tabControl1.TabIndex = 61;
            // 
            // backbtn
            // 
            backbtn.AutoSize = true;
            backbtn.BackColor = Color.FromArgb(45, 54, 76);
            backbtn.FlatAppearance.BorderColor = Color.FromArgb(45, 54, 76);
            backbtn.FlatAppearance.BorderSize = 0;
            backbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 54, 76);
            backbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 54, 76);
            backbtn.FlatStyle = FlatStyle.Flat;
            backbtn.Image = Properties.Resources.back_to_32px;
            backbtn.Location = new Point(8, 4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(46, 40);
            backbtn.TabIndex = 62;
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(516, 4);
            label1.Name = "label1";
            label1.Size = new Size(172, 23);
            label1.TabIndex = 63;
            label1.Text = "Class 12 COMPUTER";
            // 
            // class12computer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 54, 76);
            ClientSize = new Size(1213, 608);
            Controls.Add(label1);
            Controls.Add(backbtn);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "class12computer";
            Text = "class12computer";
            Load += class12computer_Load;
            modelquestionpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView22).EndInit();
            textbookpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabPage modelquestionpage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private TabPage textbookpage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TabControl tabControl1;
        private Button backbtn;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}