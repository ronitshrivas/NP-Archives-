﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.class_11
{
    public partial class class11biology : Form
    {
        private string pdfUrl = "https://drive.google.com/uc?export=view&id=1rR2LMwQL1mCYKz74WFa7Foz2t4vKv2D5";
        private string pdfFileName = "class11biologytextbook"; // The name you want to save the PDF file withbiolo
        private string pdfFolderPath = Path.Combine(Application.StartupPath, "DownloadedPDFs");
        private string localFilePath;
        private string engpdfUrl = "https://drive.google.com/uc?export=view&id=1AJLCkNmSZYonRe3BvksRAYYQHGOGTLH5";
        private string engpdfquestion = "class11bilogymodelquestion"; //
        private string localfilepaths;
        public class11biology()
        {
            InitializeComponent();
            localFilePath = Path.Combine(pdfFolderPath, pdfFileName);
            localfilepaths = Path.Combine(pdfFolderPath, engpdfquestion);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);

        }

        private async void InitBrowser()
        {
            await initizated();
           // webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1rR2LMwQL1mCYKz74WFa7Foz2t4vKv2D5");
           // webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1AJLCkNmSZYonRe3BvksRAYYQHGOGTLH5");
        }

        private void class11biology_Load(object sender, EventArgs e)
        {
            InitBrowser();
            LoadSettings();
            Loadmodelquestion();
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
                    webView22.CoreWebView2.Navigate(localfilepaths); // You can also use the Url property if you have a direct URL to the PDF.
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
                    webView21.CoreWebView2.Navigate(localFilePath); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button1.Visible = true;
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await initizated();
            button1.Enabled = false;
            downloadtextbook();
            button1.Text = string.Empty;
            button1.Text += "Please wait ....";
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
                    byte[] pdfData = await client.GetByteArrayAsync(pdfUrl);
                    File.WriteAllBytes(localFilePath, pdfData);
                    //Note Ronit that if pdf is downloaded then button will hide
                    button1.Visible = false;
                    button1.Dispose();
                    button1 = null;

                    // Load the PDF file into the WebView control.
                    webView21.CoreWebView2.Navigate(localFilePath); // You can also use the Url property if you have a direct URL to the PDF.
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
            button2.Enabled= false;
            downloadmodelquestion();
            button2.Text = string.Empty;
            button2.Text += "Please wait ....";
        }

        private async void downloadmodelquestion()
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

                    // Load the PDF file into the WebView control.
                    webView22.CoreWebView2.Navigate(localfilepaths); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
