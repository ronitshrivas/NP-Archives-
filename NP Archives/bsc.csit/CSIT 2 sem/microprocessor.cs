using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_2_sem
{
    public partial class microprocessor : Form
    {
        private string pdfUrl = "https://drive.google.com/uc?export=view&id=1A4GOVrZP8RurKqh7Oh7N0LxVhnXd9gn-";
        private string pdfFileName = "2semmicroprocessortextbook"; // The name you want to save the PDF file with
        private string pdfFolderPath = Path.Combine(Application.StartupPath, "DownloadedPDFs");
        private string localFilePath;
        private string engpdfUrl = "https://drive.google.com/uc?export=view&id=1w_YplWNhht_5n577XSRLTLtJi32s-Ve5";
        private string engpdfquestion = "2semmicroprocessoralternatingtextbook"; //
        private string localfilepaths;
        private string pdfurlpart3 = "https://drive.google.com/uc?export=view&id=1PNCfrUD1hIq50GW4pO0pFCy-64nzaxPH";
        private string pdffilname = "2semmicroprocessorexamquestion"; //
        private string localfilepath3;
        private string pdfurlpart4 = "https://drive.google.com/uc?export=view&id=11abuqw4-ovd8Tf2ZcZ7GGJqWlpnfQOiv";
        private string pdffilname4 = "2semmicroprocessorlabwork"; //
        private string localfilepath4;
        public microprocessor()
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
            String openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Microprocessor Syllabus.pdf";//PDF DOc name
            System.IO.File.WriteAllBytes(openPDFFile, Properties.Resources.Microprocessor_Syllabus);///the resource automatically creates            
            webView21.CoreWebView2.Navigate(openPDFFile);
            /*
            string opennotespdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Microprocessor Note.pdf";
           // System.IO.File.WriteAllBytes(opennotespdffile, Properties.Resources.Microprocessor_Note);///the resource automatically creates            
            webView22.CoreWebView2.Navigate(opennotespdffile);
            string openexampdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"microprocessor_book.pdf";
           // System.IO.File.WriteAllBytes(openexampdffile, Properties.Resources.microprocessor_book);///the resource automatically creates            
            webView23.CoreWebView2.Navigate(openexampdffile);
            string alternatingbook = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Exam Question mircoprocessor.pdf";
         //   System.IO.File.WriteAllBytes(alternatingbook, Properties.Resources.Exam_Question_mircoprocessor);///the resource automatically creates            
            webView24.CoreWebView2.Navigate(alternatingbook);
            string openpdflabsheet = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Microprocessor Labsheet.pdf";
           // System.IO.File.WriteAllBytes(openpdflabsheet, Properties.Resources.Microprocessor_Labsheet);///the resource automatically creates            
            webView25.CoreWebView2.Navigate(openpdflabsheet);
            */
            //  webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1tLunm9gg4id6VaXByWj-loNSf2w5XRkB");
            // webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1A4GOVrZP8RurKqh7Oh7N0LxVhnXd9gn-");
            // webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1w_YplWNhht_5n577XSRLTLtJi32s-Ve5");
            // webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1PNCfrUD1hIq50GW4pO0pFCy-64nzaxPH");
            // webView25.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=11abuqw4-ovd8Tf2ZcZ7GGJqWlpnfQOiv");
        }



        private void webView23_Click(object sender, EventArgs e)
        {

        }

        private void microprocessor_Load(object sender, EventArgs e)
        {
            InitBrowser();
            loadtextbook1();
            loadtextbook2();
            loadquestionbanksoln1();
            loadquestionbanksoln2();
        }

        private async void loadquestionbanksoln2()
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

        private async void loadquestionbanksoln1()
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

        private async void loadtextbook2()
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

        private async  void loadtextbook1()
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
            downloadtextbook();
            button1.Text = string.Empty;
            button1.Text += "Please wait ....";
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
            downloadalternatingbook();
            button2.Text = string.Empty;
            button2.Text += "Please wait ....";
        }

        private async void downloadalternatingbook()
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
            downloadexamquestion();
            button3.Text = string.Empty;
            button3.Text += "Please wait ....";
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
            button4.Enabled = false;
            downloadlabwork();
            button4.Text = string.Empty;
            button4.Text += "Please wait ....";
        }

        private async void downloadlabwork()
        {
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
