namespace NP_Archives.bsc.csit.CSIT_1_sem
{
    partial class informationtechnology
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
            components = new System.ComponentModel.Container();
            backbtn = new Button();
            tabControl1 = new TabControl();
            textbookpage = new TabPage();
            webView24 = new Microsoft.Web.WebView2.WinForms.WebView2();
            modelquestionpage = new TabPage();
            itnotesbtn = new Button();
            webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabPage1 = new TabPage();
            questionbtn = new Button();
            webView25 = new Microsoft.Web.WebView2.WinForms.WebView2();
            webView23 = new Microsoft.Web.WebView2.WinForms.WebView2();
            openFileDialog1 = new OpenFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            textbookpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView24).BeginInit();
            modelquestionpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView22).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView23).BeginInit();
            SuspendLayout();
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
            backbtn.Location = new Point(5, 5);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(46, 37);
            backbtn.TabIndex = 62;
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(textbookpage);
            tabControl1.Controls.Add(modelquestionpage);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(1, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1214, 561);
            tabControl1.TabIndex = 63;
            // 
            // textbookpage
            // 
            textbookpage.BackColor = Color.FromArgb(45, 54, 76);
            textbookpage.Controls.Add(webView24);
            textbookpage.Location = new Point(4, 28);
            textbookpage.Name = "textbookpage";
            textbookpage.Padding = new Padding(3);
            textbookpage.Size = new Size(1206, 529);
            textbookpage.TabIndex = 0;
            textbookpage.Text = "Syllabus";
            // 
            // webView24
            // 
            webView24.AllowExternalDrop = true;
            webView24.CreationProperties = null;
            webView24.DefaultBackgroundColor = Color.White;
            webView24.Dock = DockStyle.Fill;
            webView24.Location = new Point(3, 3);
            webView24.Name = "webView24";
            webView24.Size = new Size(1200, 523);
            webView24.TabIndex = 2;
            webView24.ZoomFactor = 1D;
            // 
            // modelquestionpage
            // 
            modelquestionpage.BackColor = Color.FromArgb(45, 54, 76);
            modelquestionpage.Controls.Add(itnotesbtn);
            modelquestionpage.Controls.Add(webView22);
            modelquestionpage.Location = new Point(4, 28);
            modelquestionpage.Name = "modelquestionpage";
            modelquestionpage.Padding = new Padding(3);
            modelquestionpage.Size = new Size(1206, 529);
            modelquestionpage.TabIndex = 1;
            modelquestionpage.Text = "Text Book";
            // 
            // itnotesbtn
            // 
            itnotesbtn.BackColor = Color.FromArgb(0, 192, 0);
            itnotesbtn.FlatStyle = FlatStyle.Flat;
            itnotesbtn.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            itnotesbtn.ForeColor = Color.White;
            itnotesbtn.Location = new Point(548, 234);
            itnotesbtn.Name = "itnotesbtn";
            itnotesbtn.Size = new Size(117, 49);
            itnotesbtn.TabIndex = 64;
            itnotesbtn.Text = "! Download";
            itnotesbtn.UseVisualStyleBackColor = false;
            itnotesbtn.Click += itnotesbtn_Click;
            // 
            // webView22
            // 
            webView22.AllowExternalDrop = true;
            webView22.CreationProperties = null;
            webView22.DefaultBackgroundColor = Color.White;
            webView22.Dock = DockStyle.Fill;
            webView22.Location = new Point(3, 3);
            webView22.Name = "webView22";
            webView22.Size = new Size(1200, 523);
            webView22.TabIndex = 1;
            webView22.ZoomFactor = 1D;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(45, 54, 76);
            tabPage1.Controls.Add(questionbtn);
            tabPage1.Controls.Add(webView25);
            tabPage1.Controls.Add(webView23);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1206, 529);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Question";
            // 
            // questionbtn
            // 
            questionbtn.Anchor = AnchorStyles.None;
            questionbtn.BackColor = Color.FromArgb(0, 192, 0);
            questionbtn.FlatStyle = FlatStyle.Flat;
            questionbtn.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            questionbtn.ForeColor = Color.White;
            questionbtn.Location = new Point(548, 234);
            questionbtn.Name = "questionbtn";
            questionbtn.Size = new Size(117, 49);
            questionbtn.TabIndex = 65;
            questionbtn.Text = "! Download";
            questionbtn.UseVisualStyleBackColor = false;
            questionbtn.Click += questionbtn_Click;
            // 
            // webView25
            // 
            webView25.AllowExternalDrop = true;
            webView25.CreationProperties = null;
            webView25.DefaultBackgroundColor = Color.White;
            webView25.Dock = DockStyle.Fill;
            webView25.Location = new Point(0, 0);
            webView25.Name = "webView25";
            webView25.Size = new Size(1206, 529);
            webView25.TabIndex = 64;
            webView25.ZoomFactor = 1D;
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
            webView23.Size = new Size(1206, 529);
            webView23.TabIndex = 63;
            webView23.ZoomFactor = 1D;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // informationtechnology
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 54, 76);
            ClientSize = new Size(1213, 608);
            Controls.Add(tabControl1);
            Controls.Add(backbtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "informationtechnology";
            Text = "informationtechnology";
            Load += informationtechnology_Load;
            tabControl1.ResumeLayout(false);
            textbookpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView24).EndInit();
            modelquestionpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView22).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView25).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView23).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button backbtn;
        private TabControl tabControl1;
        private TabPage textbookpage;
        private TabPage modelquestionpage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private TabPage tabPage1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView23;
        private OpenFileDialog openFileDialog1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView24;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView25;
        private Button itnotesbtn;
        private Button questionbtn;
        private System.Windows.Forms.Timer timer1;
    }
}