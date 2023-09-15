using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_1_sem
{
    public partial class digitallogics : Form
    {
        private string pdfUrl = "https://drive.google.com/uc?export=view&id=1SaDxchhB67WmSmXCVvfl_7wxjJZdOKFs";
        private string pdfFileName = "1semdigitallogictextbook"; // The name you want to save the PDF file with
        private string pdfFolderPath = Path.Combine(Application.StartupPath, "DownloadedPDFs");
        private string localFilePath;
        private string engpdfUrl = "https://drive.google.com/uc?export=view&id=1gkdiBtvX1B2ynnDpWD1cBvoUjcfM9qkg";
        private string engpdfquestion = "1semdigitallogicquestion"; //
        private string localfilepaths;
        private string pdfurlpart3 = "https://drive.google.com/uc?export=view&id=1bpdF20YxRnJv4HL585CN_VrlisEfabEU";
        private string pdffilname = "1semdigitallogiclabsheet"; //
        private string localfilepath3;
        public digitallogics()
        {
            InitializeComponent();
            localFilePath = Path.Combine(pdfFolderPath, pdfFileName);
            localfilepaths = Path.Combine(pdfFolderPath, engpdfquestion);
            localfilepath3 = Path.Combine(pdfFolderPath, pdffilname);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void webView22_Click(object sender, EventArgs e)
        {

        }

        private void webView23_Click(object sender, EventArgs e)
        {

        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);
            await webView23.EnsureCoreWebView2Async(null);
            await webView24.EnsureCoreWebView2Async(null);
        }

        private async void InitBrowser()
        {
            await initizated();
            String openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Digital Logic Syllabus.pdf";//PDF DOc name
            System.IO.File.WriteAllBytes(openPDFFile, Properties.Resources.Digital_Logic_Syllabus);///the resource automatically creates            
            webView21.CoreWebView2.Navigate(openPDFFile);
            /*
            string opennotespdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Digital Logic Notes.pdf";
          //  System.IO.File.WriteAllBytes(opennotespdffile, Properties.Resources.Digital_Logic_Notes);///the resource automatically creates            
            webView22.CoreWebView2.Navigate(opennotespdffile);
            string openexampdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"DL Exam Question.pdf";
        //    System.IO.File.WriteAllBytes(openexampdffile, Properties.Resources.DL_Exam_Questions);///the resource automatically creates            
            webView23.CoreWebView2.Navigate(openexampdffile);
            string openpdflabsheet = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Digital Logic Lab Sheet.pdf";
         //   System.IO.File.WriteAllBytes(openpdflabsheet, Properties.Resources.Digital_Logic_Lab_Sheet);///the resource automatically creates            
            webView24.CoreWebView2.Navigate(openpdflabsheet);
            */
           // webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=15dxKsbyb9wvYgAG_HUxAfQcwcLGPmJe7");
           // webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1SaDxchhB67WmSmXCVvfl_7wxjJZdOKFs");
           // webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1gkdiBtvX1B2ynnDpWD1cBvoUjcfM9qkg");
            //webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1bpdF20YxRnJv4HL585CN_VrlisEfabEU");
        }

            

        private void digitallogics_Load(object sender, EventArgs e)
        {
            InitBrowser();
            LoadSettings();
            Loadmodelquestion();
            loadsamplequestion();
        }

        private async void loadsamplequestion()
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

        private async void Loadmodelquestion()
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

        private async void LoadSettings()
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

       

        private void Savesetting()
        {
            Properties.Settings.Default.IsPdfDownloaded = true;
            Properties.Settings.Default.Save();
        }

        
      

       
      

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = false;

            Downloadquestion();
            button2.Text = string.Empty;
            button2.Text += "Please wait ....";
        }

        private async void Downloadquestion()
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

            downloadlabsheet();
            button3.Text = string.Empty;
            button3.Text += "Please wait ....";
        }

        private async void downloadlabsheet()
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
    }
}
