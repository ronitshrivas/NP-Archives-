using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_3_sem
{
    public partial class computergraphics : Form
    {
        
        private string pdfUrl = "https://drive.google.com/uc?export=view&id=1mF0R-f99G-qa-LN2YHsCeGO01L7_osof";
        private string pdfFileName = "3rdsemcomputergraphicsnotes"; // The name you want to save the PDF file with
        private string pdfFolderPath = Path.Combine(Application.StartupPath, "DownloadedPDFs");
        private string localFilePath;
        private string engpdfUrl = "https://drive.google.com/uc?export=view&id=1giEeZNoK0Pl7BsjXtg6ATll3jyfGOsLQ";
        private string engpdfquestion = "3rdsemcomputergraphicsexamquestion"; //
        private string localfilepaths;
        private string pdfurlpart3 = "https://drive.google.com/uc?export=view&id=1vkjVHN7EGD29aMOxAnBk6hfD1pdR74HM";
        private string pdffilname = "3rdsemcomputergraphictextbook"; //
        private string localfilepath3;
        private string pdfurlpart4 = "https://drive.google.com/uc?export=view&id=1NSRpQ7MmmfDhbsli8TwmoBZX7Gn2G0p9";
        private string pdffilname4 = "csit3rdsemdCGoldisgold"; //
        private string localfilepath4;
        public computergraphics()
        {
            InitializeComponent();
            localFilePath = Path.Combine(pdfFolderPath, pdfFileName);
            localfilepaths = Path.Combine(pdfFolderPath, engpdfquestion);
            localfilepath3 = Path.Combine(pdfFolderPath, pdffilname);
            localfilepath4 = Path.Combine(pdfFolderPath, pdffilname4);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);
            await webView23.EnsureCoreWebView2Async(null);
            await webView24.EnsureCoreWebView2Async(null);
            await webView25.EnsureCoreWebView2Async(null);

        }

        private async void InitBrowser()
        {
            await initizated();
            String openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Computer Graphics exam question 3rd sem.pdf";//PDF DOc name
            System.IO.File.WriteAllBytes(openPDFFile, Properties.Resources.Computer_Graphics_Syllabus);///the resource automatically creates            
            webView21.CoreWebView2.Navigate(openPDFFile);
            /*
            string opennotespdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Computer Graphics Note by Maruti Dhungana.pdf";
        //    System.IO.File.WriteAllBytes(opennotespdffile, Properties.Resources.Computer_Graphics_Note_by_Maruti_Dhungana);///the resource automatically creates            
            webView22.CoreWebView2.Navigate(opennotespdffile);
            string openexampdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Computer Graphics Syllabus.pdf";
           // System.IO.File.WriteAllBytes(openexampdffile, Properties.Resources.Computer_Graphics_exam_question_3rd_sem);///the resource automatically creates            
            webView23.CoreWebView2.Navigate(openexampdffile);
            string opentextbook = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Computer Graphics.pdf";
          //  System.IO.File.WriteAllBytes(opentextbook, Properties.Resources.Computer_Graphics);
            webView24.CoreWebView2.Navigate(opentextbook);
            */
            //   webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1mKDRHmPPerdajjeLzQ7aX7wWAo4_UmD3");
            //  webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1mF0R-f99G-qa-LN2YHsCeGO01L7_osof");
            //  webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1giEeZNoK0Pl7BsjXtg6ATll3jyfGOsLQ");
        }

        private void computergraphics_Load(object sender, EventArgs e)
        {
            InitBrowser();
            loadnotes();
            loadexamquestion();
            loadtextbook();
            loadoldisgoldsoln();
        }

        private async void loadoldisgoldsoln()
        {
            await initizated();
            if (File.Exists(localfilepath4))
            {
                try
                {
                    button4.Visible = false;
                    button4.Dispose();
                    button4 = null;

                    // Load the PDF file into the WebView control.
                    webView25.CoreWebView2.Navigate(localfilepath4); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button4.Visible = true;
                }
            }
        }

        private async void loadtextbook()
        {
            await initizated();
            if (File.Exists(localfilepath3))
            {
                try
                {
                    button3.Visible = false;
                    button3.Dispose();
                    button3 = null;

                    // Load the PDF file into the WebView control.
                    webView24.CoreWebView2.Navigate(localfilepath3); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button3.Visible = true;
                }
            }
        }

        private async void loadexamquestion()
        {
            await initizated();
            if (File.Exists(localfilepaths))
            {
                try
                {
                    button2.Visible = false;
                    button2.Dispose();
                    button2 = null;

                    // Load the PDF file into the WebView control.
                    webView23.CoreWebView2.Navigate(localfilepaths); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button2.Visible = true;
                }
            }
        }

        private async void loadnotes()
        {
            await initizated();
            if (File.Exists(localFilePath))
            {
                try
                {
                    button1.Visible = false;
                    button1.Dispose();
                    button1 = null;

                    // Load the PDF file into the WebView control.
                    webView22.CoreWebView2.Navigate(localFilePath); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button1.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            downloadnotes();
            button1.Text = string.Empty;
            button1.Text += "Please wait ....";
        }

        private async void downloadnotes()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Create the PDF folder if it doesn't exist.
                    if (!Directory.Exists(pdfFolderPath))
                        Directory.CreateDirectory(pdfFolderPath);

                    // Download the PDF file and save it to the PDF folder.
                    byte[] pdfData = await client.GetByteArrayAsync(pdfUrl);
                    File.WriteAllBytes(localFilePath, pdfData);
                    //Note Ronit that if pdf is downloaded then button will hide
                    button1.Visible = false;
                    button1.Dispose();
                    button1 = null;

                    // Load the PDF file into the WebView control.
                    webView22.CoreWebView2.Navigate(localFilePath); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            downloadexamquestion();
            button2.Text = string.Empty;
            button2.Text += "Please wait ....";
        }

        private async void downloadexamquestion()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Create the PDF folder if it doesn't exist.
                    if (!Directory.Exists(pdfFolderPath))
                        Directory.CreateDirectory(pdfFolderPath);

                    // Download the PDF file and save it to the PDF folder.
                    byte[] pdfData = await client.GetByteArrayAsync(engpdfUrl);
                    File.WriteAllBytes(localfilepaths, pdfData);
                    //Note Ronit that if pdf is downloaded then button will hide
                    button2.Visible = false;
                    button2.Dispose();
                    button2 = null;

                    // Load the PDF file into the WebView control.
                    webView23.CoreWebView2.Navigate(localfilepaths); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;

            downloadtextbook();
            button3.Text = string.Empty;
            button3.Text += "Please wait ....";
        }

        private async void downloadtextbook()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Create the PDF folder if it doesn't exist.
                    if (!Directory.Exists(pdfFolderPath))
                        Directory.CreateDirectory(pdfFolderPath);

                    // Download the PDF file and save it to the PDF folder.
                    byte[] pdfData = await client.GetByteArrayAsync(pdfurlpart3);
                    File.WriteAllBytes(localfilepath3, pdfData);
                    //Note Ronit that if pdf is downloaded then button will hide
                    button3.Visible = false;
                    button3.Dispose();
                    button3 = null;

                    // Load the PDF file into the WebView control.
                    webView24.CoreWebView2.Navigate(localfilepath3); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            downloadoldisgoldsoln();
            button4.Enabled = false;
            button4.Text = string.Empty;
            button4.Text += "Please wait ....";
        }

        private async void downloadoldisgoldsoln()
        {
            await initizated();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Create the PDF folder if it doesn't exist.
                    if (!Directory.Exists(pdfFolderPath))
                        Directory.CreateDirectory(pdfFolderPath);

                    // Download the PDF file and save it to the PDF folder.
                    byte[] pdfData = await client.GetByteArrayAsync(pdfurlpart4);
                    File.WriteAllBytes(localfilepath4, pdfData);
                    //Note Ronit that if pdf is downloaded then button will hide
                    button4.Visible = false;
                    button4.Dispose();
                    button4 = null;

                    // Load the PDF file into the WebView control.
                    webView25.CoreWebView2.Navigate(localfilepath4); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
