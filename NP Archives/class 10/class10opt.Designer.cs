namespace NP_Archives.class_10
{
    partial class class10opt
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
            webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            smpqustionpage = new TabPage();
            webView23 = new Microsoft.Web.WebView2.WinForms.WebView2();
            label1 = new Label();
            backbtn = new Button();
            tabControl1.SuspendLayout();
            textbookpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            modelquestionpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView22).BeginInit();
            smpqustionpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView23).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(textbookpage);
            tabControl1.Controls.Add(modelquestionpage);
            tabControl1.Controls.Add(smpqustionpage);
            tabControl1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(1, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1210, 562);
            tabControl1.TabIndex = 66;
            // 
            // textbookpage
            // 
            textbookpage.BackColor = Color.FromArgb(45, 54, 76);
            textbookpage.Controls.Add(webView21);
            textbookpage.Location = new Point(4, 28);
            textbookpage.Name = "textbookpage";
            textbookpage.Padding = new Padding(3);
            textbookpage.Size = new Size(1202, 530);
            textbookpage.TabIndex = 0;
            textbookpage.Text = "Text Book";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(3, 3);
            webView21.Name = "webView21";
            webView21.Size = new Size(1196, 524);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // modelquestionpage
            // 
            modelquestionpage.BackColor = Color.FromArgb(45, 54, 76);
            modelquestionpage.Controls.Add(webView22);
            modelquestionpage.Location = new Point(4, 28);
            modelquestionpage.Name = "modelquestionpage";
            modelquestionpage.Padding = new Padding(3);
            modelquestionpage.Size = new Size(1202, 530);
            modelquestionpage.TabIndex = 1;
            modelquestionpage.Text = "Model Question";
            // 
            // webView22
            // 
            webView22.AllowExternalDrop = true;
            webView22.CreationProperties = null;
            webView22.DefaultBackgroundColor = Color.White;
            webView22.Dock = DockStyle.Fill;
            webView22.Location = new Point(3, 3);
            webView22.Name = "webView22";
            webView22.Size = new Size(1196, 524);
            webView22.TabIndex = 1;
            webView22.ZoomFactor = 1D;
            // 
            // smpqustionpage
            // 
            smpqustionpage.BackColor = Color.FromArgb(45, 54, 76);
            smpqustionpage.Controls.Add(webView23);
            smpqustionpage.Location = new Point(4, 28);
            smpqustionpage.Name = "smpqustionpage";
            smpqustionpage.Padding = new Padding(3);
            smpqustionpage.Size = new Size(1202, 530);
            smpqustionpage.TabIndex = 2;
            smpqustionpage.Text = "Sample Question";
            // 
            // webView23
            // 
            webView23.AllowExternalDrop = true;
            webView23.CreationProperties = null;
            webView23.DefaultBackgroundColor = Color.White;
            webView23.Dock = DockStyle.Fill;
            webView23.Location = new Point(3, 3);
            webView23.Name = "webView23";
            webView23.Size = new Size(1196, 524);
            webView23.TabIndex = 2;
            webView23.ZoomFactor = 1D;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(520, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 65;
            label1.Text = "Class 10 O.P.T";
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
            backbtn.Location = new Point(1, 2);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(46, 40);
            backbtn.TabIndex = 64;
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // class10opt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 54, 76);
            ClientSize = new Size(1213, 608);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(backbtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "class10opt";
            Text = "class10opt";
            Load += class10opt_Load;
            tabControl1.ResumeLayout(false);
            textbookpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            modelquestionpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView22).EndInit();
            smpqustionpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView23).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage textbookpage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TabPage modelquestionpage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private TabPage smpqustionpage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView23;
        private Label label1;
        private Button backbtn;
    }
}