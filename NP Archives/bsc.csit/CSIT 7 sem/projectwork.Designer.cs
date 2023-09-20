namespace NP_Archives.bsc.csit.CSIT_7_sem
{
    partial class projectwork
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
            backbtn = new Button();
            tabControl1 = new TabControl();
            textbookpage = new TabPage();
            button1 = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabControl1.SuspendLayout();
            textbookpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
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
            backbtn.TabIndex = 67;
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(textbookpage);
            tabControl1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(1, 47);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1210, 557);
            tabControl1.TabIndex = 66;
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
            textbookpage.Text = "Proposal Format";
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
            button1.TabIndex = 74;
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
            // projectwork
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 54, 76);
            ClientSize = new Size(1213, 608);
            Controls.Add(backbtn);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "projectwork";
            Text = "projectwork";
            Load += projectwork_Load;
            tabControl1.ResumeLayout(false);
            textbookpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backbtn;
        private TabControl tabControl1;
        private TabPage textbookpage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button1;
    }
}