namespace NP_Archives
{
    partial class startup_age
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startup_age));
            label1 = new Label();
            label2 = new Label();
            timefader = new System.Windows.Forms.Timer(components);
            tmrwastetine = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(146, 61);
            label1.Name = "label1";
            label1.Size = new Size(206, 65);
            label1.TabIndex = 0;
            label1.Text = "NI Tutor";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(218, 142);
            label2.Name = "label2";
            label2.Size = new Size(292, 27);
            label2.TabIndex = 1;
            label2.Text = "Made By Ronit Shrivastav (RS7)";
            // 
            // timefader
            // 
            timefader.Tick += timefader_Tick;
            // 
            // tmrwastetine
            // 
            tmrwastetine.Interval = 1000;
            tmrwastetine.Tick += tmrwastetine_Tick;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(282, 21);
            label3.TabIndex = 2;
            label3.Text = "Soon Update Come With A.I. Chatbot";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.DodgerBlue;
            progressBar1.Location = new Point(-2, 189);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(523, 23);
            progressBar1.Step = 20;
            progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // startup_age
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 54, 76);
            ClientSize = new Size(522, 213);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "startup_age";
            StartPosition = FormStartPosition.CenterScreen;
            Load += startup_age_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timefader;
        private System.Windows.Forms.Timer tmrwastetine;
        private Label label3;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}