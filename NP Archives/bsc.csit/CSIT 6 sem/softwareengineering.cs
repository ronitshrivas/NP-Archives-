﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_6_sem
{
    public partial class softwareengineering : Form
    {

        private string pdfUrl = "https://drive.google.com/uc?export=view&id=1lDiNxHVnTPxk167kQS8QmA3zOPEsNiys";
        private string pdfFileName = "csit6semsoftwareengnotes"; // The name you want to save the PDF file with
        private string pdfFolderPath = Path.Combine(Application.StartupPath, "DownloadedPDFs");
        private string localFilePath;
        private string engpdfUrl = "https://drive.google.com/uc?export=view&id=1cvtnhLFxPxdktxEYam7alZNZq2ayQIak";
        private string engpdfquestion = "csit6semsoftwareengexamquestion"; //
        private string localfilepaths;
        private string pdfurlpart3 = "https://drive.google.com/uc?export=view&id=11g8-qR4NIV7z8QD725d5xZ_OVC2MK32X";
        private string pdffilname = "csit6semsoftwareengmodelquestion"; //
        private string localfilepath3;
        private string pdfurlpart4 = "https://drive.google.com/uc?export=view&id=104cu-XxuxSHZzCTKKD7yThRz7OsKT_fT";
        private string pdffilname4 = "csit6semsoftwareengtextbook"; //
        private string localfilepath4;
        public softwareengineering()
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
            String openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Software Engineering Syllabus.pdf";//PDF DOc name
            System.IO.File.WriteAllBytes(openPDFFile, Properties.Resources.Software_Engineering_Syllabus);///the resource automatically creates            
            webView21.CoreWebView2.Navigate(openPDFFile);
            /*
            string opennotespdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Software Engineering Note.pdf";
          //  System.IO.File.WriteAllBytes(opennotespdffile, Properties.Resources.Software_Engineering_Note);///the resource automatically creates            
            webView22.CoreWebView2.Navigate(opennotespdffile);
            string openexampdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Software Engineering Exam Question.pdf";
           // System.IO.File.WriteAllBytes(openexampdffile, Properties.Resources.Software_Engineering_Exam_Question);///the resource automatically creates            
            webView23.CoreWebView2.Navigate(openexampdffile);
            */
            // webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1i5S1v3B6n-LTIE5-ICpN0lkjvkQVBGgM");
            // webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1lDiNxHVnTPxk167kQS8QmA3zOPEsNiys");
            // webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1cvtnhLFxPxdktxEYam7alZNZq2ayQIak");
        }

        private void softwareengineering_Load(object sender, EventArgs e)
        {
            InitBrowser();
            loadnotes();
            loadexamquestion();
            loadmodelquestion();
            loadtextbook();
        }

        private async void loadtextbook()
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

        private async void loadmodelquestion()
        {
            await initizated();
            if (File.Exists(localfilepath3))
            {
                try
                {
                    button3.Visible = false;
                    button3.Dispose();
                    button3 = null;
                    await initizated();

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

        private async void button3_Click(object sender, EventArgs e)
        {
            await initizated();
            button3.Enabled = false;
            downloadmodelquestion();
            button3.Text = string.Empty;
            button3.Text += "Please wait ....";
        }

        private async void downloadmodelquestion()
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
                    byte[] pdfData = await client.GetByteArrayAsync(pdfurlpart3);
                    File.WriteAllBytes(localfilepath3, pdfData);
                    //Note Ronit that if pdf is downloaded then button will hide
                    button3.Visible = false;
                    button3.Dispose();
                    button3 = null;
                    await initizated();

                    // Load the PDF file into the WebView control.
                    webView24.CoreWebView2.Navigate(localfilepath3); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await initizated();
            button1.Enabled = false;
            downloadnotes();
            button1.Text = string.Empty;
            button1.Text += "Please wait ....";
        }

        private async void downloadnotes()
        {
            await initizated();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(300);
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
                    await initizated();

                    // Load the PDF file into the WebView control.
                    webView22.CoreWebView2.Navigate(localFilePath); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await initizated();
            button2.Enabled = false;
            downloadexamquestion();
            button2.Text = string.Empty;
            button2.Text += "Please wait ....";
        }

        private async void downloadexamquestion()
        {
            await initizated();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(300);
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
                    await initizated();

                    // Load the PDF file into the WebView control.
                    webView23.CoreWebView2.Navigate(localfilepaths); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void webView25_Click(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await initizated();
            button4.Enabled = false;
            downloadtextbook();
            button4.Text = string.Empty;
            button4.Text += "Please wait ....";
        }

        private async void downloadtextbook()
        {
            await initizated();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(300);
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
                    await initizated();

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
