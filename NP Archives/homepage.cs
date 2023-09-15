using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Windows.Devices.Radios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace NP_Archives
{
    public partial class homepage : Form
    {
        private Size formOriginalSize;
        private Rectangle recschoolbtn;
        private Rectangle collegebtn;
        private Rectangle bachelorbtn;
        private Rectangle programmingbtn;
        private Rectangle recschoolpic;
        private Rectangle reccollegepic;
        private Rectangle recbachelorpic;
        private Rectangle recprogrammingpic;


        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);

        int mov;
        int movX;
        int movY;
        public homepage()
        {
            InitializeComponent();
            this.Resize += homepage_Resize;
            formOriginalSize = this.Size;
            recschoolbtn = new Rectangle(button6.Location, button6.Size);
            collegebtn = new Rectangle(btncollegelevel.Location, btncollegelevel.Size);
            bachelorbtn = new Rectangle(button2.Location, button2.Size);
            programmingbtn = new Rectangle(button1.Location, button1.Size);

            recschoolpic = new Rectangle(pictureBox2.Location, pictureBox2.Size);
            reccollegepic = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recbachelorpic = new Rectangle(pictureBox3.Location, pictureBox3.Size);
            recprogrammingpic = new Rectangle(pictureBox4.Location, pictureBox4.Size);

            //button6.FlatAppearance.BorderSize = 0;
            // button6.Paint += button6_Paint;

        }



        public void homepage_Load(object sender, EventArgs e)
        {
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            // if(this.WindowState == FormWindowState.Normal)
            //{
            // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //}

            timer1.Start();
            lbltimer.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();

            //checking internet connection
            int Out;
            if (InternetGetConnectedState(out Out, 0) == true)
            {
                lblinternetconnectioncheck.Text = "Connected To Server";
                lblinternetconnectioncheck.ForeColor = Color.Green;
            }
            else
            {
                lblinternetconnectioncheck.Text = "Oops! You Are not Connected to Server";
                lblinternetconnectioncheck.ForeColor = Color.Red;
            }
        }



        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            startup_age stp = new startup_age();
            stp.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Restore to the previous window state
                this.WindowState = previousWindowState;
            }
            else
            {
                // Maximize the window
                previousWindowState = this.WindowState; // Store the current window state
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }



        private Form activeForm = null;
        private FormWindowState previousWindowState;

        private void gotoschool(schoollevel ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            backgrod.Controls.Add(ChildForm);
            backgrod.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }



        public void backgrod_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lbltimer.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }



        private void gotocollege(collegelevel ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            backgrod.Controls.Add(ChildForm);
            backgrod.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }


        private void gotobachelors(bachelorslevel ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            backgrod.Controls.Add(ChildForm);
            backgrod.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void gotoprogramminghacking(Programmingandhacking ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            backgrod.Controls.Add(ChildForm);
            backgrod.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            gotobachelors(new bachelorslevel());

        }

        private void btncollegelevel_Click_1(object sender, EventArgs e)
        {
            gotocollege(new collegelevel());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gotoprogramminghacking(new Programmingandhacking());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            gotoschoolpage(new schoollevel());
        }

        private void gotoschoolpage(schoollevel ChildForm)
        {
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            backgrod.Controls.Add(ChildForm);
            backgrod.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void button6_Paint_1(object sender, PaintEventArgs e)
        {
        }


        private void homepage_Resize(object sender, EventArgs e)
        {
            resize_Control(button6, recschoolbtn);
            resize_Control(btncollegelevel, collegebtn);
            resize_Control(button2, bachelorbtn);
            resize_Control(button1, programmingbtn);

            resize_Control(pictureBox2, recschoolpic);
            resize_Control(pictureBox1, reccollegepic);
            resize_Control(pictureBox3, recbachelorpic);
            resize_Control(pictureBox4, recprogrammingpic);
        }


        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
    }
}