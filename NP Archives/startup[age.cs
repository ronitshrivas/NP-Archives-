using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace NP_Archives
{
    public partial class startup_age : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
   int nLeftRect,     // x-coordinate of upper-left corner
   int nTopRect,      // y-coordinate of upper-left corner
   int nRightRect,    // x-coordinate of lower-right corner
   int nBottomRect,   // y-coordinate of lower-right corner
   int nWidthEllipse, // width of ellipse
   int nHeightEllipse // height of ellipse
);

        private FormWindowState previousWindowState;


        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);

        public startup_age()
        {
            InitializeComponent();
        }

        private void startup_age_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
           
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
           
        }

        private void timefader_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.01)
            {
                this.Opacity = this.Opacity - 0.03;

            }
            else
                kill_tmrFader();
            
        }
        homepage hmp = new homepage();

        private void kill_tmrFader()
        {
            timefader.Stop();
            hmp.ShowDialog();
            startup_age stp = new startup_age();

            this.Close();
        }

        private void tmrwastetine_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            tmrwastetine.Stop();
            timefader.Start();
            
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            progressBar1.Style = ProgressBarStyle.Continuous;
            if (progressBar1.Value == 100)
            {
                tmrwastetine.Start();
            }

        }
    }
}
