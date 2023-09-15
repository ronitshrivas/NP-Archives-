using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace NP_Archives
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       // private Form activeForm = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "c0mm@ndf0r777")
            {
                this.Close();
                //gotoprogramming(new Programmingandhacking());

            }
        }

        public void gotoprogramming(Programmingandhacking ChildForm)
        {
            /*if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
           homepage.backgrod.Controls.Add(ChildForm);
            homepage.backgrod.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            */
        }
    }
}