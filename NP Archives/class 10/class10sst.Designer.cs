﻿namespace NP_Archives
{
    partial class class10sst
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textbookpage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.modelquestionpage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.textbookpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.modelquestionpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.textbookpage);
            this.tabControl1.Controls.Add(this.modelquestionpage);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(1, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1210, 562);
            this.tabControl1.TabIndex = 66;
            // 
            // textbookpage
            // 
            this.textbookpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.textbookpage.Controls.Add(this.button1);
            this.textbookpage.Controls.Add(this.webView21);
            this.textbookpage.Location = new System.Drawing.Point(4, 28);
            this.textbookpage.Name = "textbookpage";
            this.textbookpage.Padding = new System.Windows.Forms.Padding(3);
            this.textbookpage.Size = new System.Drawing.Size(1202, 530);
            this.textbookpage.TabIndex = 0;
            this.textbookpage.Text = "Text Book";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(548, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 74;
            this.button1.Text = "! Download";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(3, 3);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1196, 524);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // modelquestionpage
            // 
            this.modelquestionpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.modelquestionpage.Controls.Add(this.button2);
            this.modelquestionpage.Controls.Add(this.webView22);
            this.modelquestionpage.Location = new System.Drawing.Point(4, 28);
            this.modelquestionpage.Name = "modelquestionpage";
            this.modelquestionpage.Padding = new System.Windows.Forms.Padding(3);
            this.modelquestionpage.Size = new System.Drawing.Size(1202, 530);
            this.modelquestionpage.TabIndex = 1;
            this.modelquestionpage.Text = "Question Paper";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(548, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 46);
            this.button2.TabIndex = 74;
            this.button2.Text = "! Download";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webView22
            // 
            this.webView22.AllowExternalDrop = true;
            this.webView22.CreationProperties = null;
            this.webView22.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView22.Location = new System.Drawing.Point(3, 3);
            this.webView22.Name = "webView22";
            this.webView22.Size = new System.Drawing.Size(1196, 524);
            this.webView22.TabIndex = 1;
            this.webView22.ZoomFactor = 1D;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(520, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 65;
            this.label1.Text = "Class 10 S.S.T";
            // 
            // backbtn
            // 
            this.backbtn.AutoSize = true;
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.backbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.backbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = global::NP_Archives.Properties.Resources.back_to_32px;
            this.backbtn.Location = new System.Drawing.Point(1, 2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(46, 40);
            this.backbtn.TabIndex = 64;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // class10sst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1213, 608);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "class10sst";
            this.Text = "class10sst";
            this.Load += new System.EventHandler(this.class10sst_Load);
            this.tabControl1.ResumeLayout(false);
            this.textbookpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.modelquestionpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button button1;
        private Button button2;
    }
}