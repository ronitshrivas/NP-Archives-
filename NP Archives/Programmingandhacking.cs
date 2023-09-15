using NP_Archives.Programming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives
{
    public partial class Programmingandhacking : Form
    {
        public Programmingandhacking()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Form? activeForm = null;

        private void javabtn_Click(object sender, EventArgs e)
        {
            gotojavapage(new java());
        }

        private void gotojavapage(java ChildForm)
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

        private void phpbtn_Click(object sender, EventArgs e)
        {
            gotophppage(new php());
        }

        private void gotophppage(php ChildForm)
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

        private void pythonbtn_Click(object sender, EventArgs e)
        {
            gotopythonpage(new python());
        }

        private void gotopythonpage(python ChildForm)
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

        private void javascriptbtn_Click(object sender, EventArgs e)
        {
            gotojavascriptpage(new javascript());
        }

        private void gotojavascriptpage(javascript ChildForm)
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

        private void csharpbtn_Click(object sender, EventArgs e)
        {
            gotocsharppage(new csharp());
        }

        private void gotocsharppage(csharp ChildForm)
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

        private void androidstudiobtn_Click(object sender, EventArgs e)
        {
            gotoandroidstudiopage(new androidstudio());
        }

        private void gotoandroidstudiopage(androidstudio ChildForm)
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ethicalhackingbtn_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.ShowDialog();
        }
    }
}
