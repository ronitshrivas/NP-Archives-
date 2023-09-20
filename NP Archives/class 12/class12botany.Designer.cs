namespace NP_Archives.class_12
{
    partial class class12botany
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
            label1 = new Label();
            backbtn = new Button();
            tabControl1 = new TabControl();
            Practicalcopypage = new TabPage();
            button1 = new Button();
            webView24 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabControl1.SuspendLayout();
            Practicalcopypage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView24).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(516, 4);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 63;
            label1.Text = "Class 12 BOTANY";
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
            backbtn.Location = new Point(1, 4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(46, 40);
            backbtn.TabIndex = 62;
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(Practicalcopypage);
            tabControl1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(1, 47);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1214, 557);
            tabControl1.TabIndex = 64;
            // 
            // Practicalcopypage
            // 
            Practicalcopypage.Controls.Add(button1);
            Practicalcopypage.Controls.Add(webView24);
            Practicalcopypage.Location = new Point(4, 28);
            Practicalcopypage.Name = "Practicalcopypage";
            Practicalcopypage.Size = new Size(1206, 525);
            Practicalcopypage.TabIndex = 3;
            Practicalcopypage.Text = "Practical Copy";
            Practicalcopypage.UseVisualStyleBackColor = true;
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
            button1.TabIndex = 75;
            button1.Text = "! Download";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // webView24
            // 
            webView24.AllowExternalDrop = true;
            webView24.BackColor = Color.FromArgb(45, 54, 76);
            webView24.CreationProperties = null;
            webView24.DefaultBackgroundColor = Color.White;
            webView24.Dock = DockStyle.Fill;
            webView24.Location = new Point(0, 0);
            webView24.Name = "webView24";
            webView24.Size = new Size(1206, 525);
            webView24.TabIndex = 1;
            webView24.ZoomFactor = 1D;
            // 
            // class12botany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 54, 76);
            ClientSize = new Size(1213, 608);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(backbtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "class12botany";
            Text = "class12botany";
            Load += class12botany_Load;
            tabControl1.ResumeLayout(false);
            Practicalcopypage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView24).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button backbtn;
        private TabControl tabControl1;
        private TabPage Practicalcopypage;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView24;
        private Button button1;
    }
}