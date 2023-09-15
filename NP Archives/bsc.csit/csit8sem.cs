using NP_Archives.bsc.csit.CSIT_8_sem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit
{
    public partial class csit8sem : Form
    {
        public csit8sem()
        {
            InitializeComponent();
        }

        private void csit8sem_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Form? activeForm = null;

        private void btnadvanceddatabase_Click(object sender, EventArgs e)
        {
            gotoadvanceddatabase(new advanceddatabase());
        }

        private void gotoadvanceddatabase(advanceddatabase ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btninternship_Click(object sender, EventArgs e)
        {
            gotointernship(new internship());
        }

        private void gotointernship(internship ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnneuralnetworks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cooming Soon...");
        }

        private void btncomputerhardwaredesign_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cooming Soon...");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cooming Soon...");
        }

        private void btnappliedlogics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cooming Soon...");
        }

        private void btnecommerce_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cooming Soon...");
        }

        private void btnrobotics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cooming Soon...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cooming Soon...");
        }

        private void btncognitivedesign_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cooming Soon...");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cooming Soon...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cooming Soon...");
        }
    }
}
