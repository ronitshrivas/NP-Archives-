using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using NP_Archives.BCA;
using NP_Archives.bsc.csit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NP_Archives
{
    public partial class bachelorslevel : Form
    {
        private WebView2 webView;
        private string pdfFolderPath = Path.Combine(Application.StartupPath, "DownloadedPDFs");

        public bachelorslevel()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            try
            {
                await initizated();
                // Specify the data directory path
                // string dataDirectoryPath = @"C:\Your\Data\Directory"; // Replace with your data directory path

                // Create WebView2 environment options
                CoreWebView2EnvironmentOptions options = new CoreWebView2EnvironmentOptions();

                // Initialize WebView2 environment with the specified data directory
                CoreWebView2Environment environment = await CoreWebView2Environment.CreateAsync(userDataFolder: pdfFolderPath, options: options);

                // webView21 = new WebView2();
                //await webView21.EnsureCoreWebView2Async(null);


                //  webView2.CoreWebView2.Navigate("https://www.google.com/");

                // Navigate to a webpage
                webView21.Source = new Uri("https://google.com/"); // Replace with your initial URL
            }
            catch (Exception ex)
            {
                // Handle initialization error
                MessageBox.Show($"WebView2 initialization error: {ex.Message}");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclass9hpe_Click(object sender, EventArgs e)
        {
            gotocsit5sem(new csit5sem());
        }

        private void gotocsit5sem(csit5sem ChildForm)
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

        private Form? activeForm = null;


        private void btnclass9computer_Click(object sender, EventArgs e)
        {
            gotocsit8sem(new csit8sem());
        }

        private void gotocsit8sem(csit8sem ChildForm)
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

        private async void bachelorslevel_Load(object sender, EventArgs e)
        {
            await initizated();
            InitBrowser();
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
            // string dataDirectoryPath = @"C:\Your\Data\Directory"; // Replace with your data directory path
            // CoreWebView2EnvironmentOptions options = new CoreWebView2EnvironmentOptions();
            // CoreWebView2Environment environment = await CoreWebView2Environment.CreateAsync(userDataFolder: pdfFolderPath, options: options);
            // webView21 = new WebView2();
            // webView21.CoreWebView2.Environment = environment;


            //  webView21.Source = new Uri("https://www.google.com/");

            // Initialize WebView2 with the specified data directory
            // await webView21.EnsureCoreWebView2Async(null);
        }

        private async void InitBrowser()
        {
            await initizated();
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate("https://www.google.com/");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void csit1stsem_Click(object sender, EventArgs e)
        {
            gotocsit1sem(new csit1sem());
        }

        private void gotocsit1sem(csit1sem ChildForm)
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

        private void csit2ndsem_Click(object sender, EventArgs e)
        {
            gotocsit2sem(new csit2sem());
        }

        private void gotocsit2sem(csit2sem ChildForm)
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

        private void csit3rdsem_Click(object sender, EventArgs e)
        {
            gotocsit3sem(new csit3sem());
        }

        private void gotocsit3sem(csit3sem ChildForm)
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

        private void csit4thsem_Click(object sender, EventArgs e)
        {
            gotocsit4sem(new csit4sem());
        }

        private void gotocsit4sem(csit4sem ChildForm)
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

        private void csit6thsem_Click(object sender, EventArgs e)
        {
            gotocsit6sem(new csit6sem());
        }

        private void gotocsit6sem(csit6sem ChildForm)
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

        private void csit7thsem_Click(object sender, EventArgs e)
        {
            gotocsit7sem(new csit7sem());
        }

        private void gotocsit7sem(csit7sem ChildForm)
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



        private void bca1sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server Maintainence", MessageBoxButtons.OK.ToString());

            //gototbca1sempage(new bca1sem());
        }

        private void gototbca1sempage(bca1sem ChildForm)
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

        private void bca2sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server Maintainence", MessageBoxButtons.OK.ToString());

        }

        private void bca3sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server Maintainence", MessageBoxButtons.OK.ToString());
        }

        private void bca4sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server Maintainence", MessageBoxButtons.OK.ToString());
        }

        private void bca5sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server Maintainence", MessageBoxButtons.OK.ToString());
        }

        private void bca6sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server Maintainence", MessageBoxButtons.OK.ToString());
        }

        private void bca7sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server Maintainence", MessageBoxButtons.OK.ToString());
        }

        private void bca8sem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server Maintainence", MessageBoxButtons.OK.ToString());
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await initizated();
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate(textBox1.Text);

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                GetBotResponse();
                e.Handled = e.SuppressKeyPress = true; //This Code for Disabling Beep Sound On Enter Key
            }
        }

        private async void GetBotResponse()
        {
            await initizated();
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate(textBox1.Text);

            }
        }

        private async Task itnitied()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private async void browserinit()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://www.tuiost.edu.np/notice");
        }


        private void btnnews_Click(object sender, EventArgs e)
        {
            browserinit();
            //username();

        }

        /* private void username()
         {
             HtmlWeb web = new HtmlWeb();
             HtmlAgilityPack.HtmlDocument document = web.Load("https://www.tuiost.edu.np/notices");
             var usertext = document.DocumentNode.SelectNodes("//*[@id=\"notices\"]/div/div[2]/ul/li[9]/featured-content").First().InnerText;
             textBox2.Text = usertext;
         }
        */


    }
}
