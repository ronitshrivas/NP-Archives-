using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;


namespace NP_Archives
{
    public partial class class9english : Form
    {

        private bool textbookpdf;
        private string pdfUrl = "https://drive.google.com/uc?export=view&id=1qFcmQ7Thmttj8kbrhTQW6JDFa5KgfWhV";
        private string pdfFileName = "Class9englishtextbook"; // The name you want to save the PDF file with
        private string pdfFolderPath = Path.Combine(Application.StartupPath, "DownloadedPDFs");
        private string localFilePath;
        private string engpdfUrl = "https://drive.google.com/uc?export=view&id=1Pe-Yekeh_5cnBrvlCVRiY9T2Ee9POl-R";
        private string engpdfquestion = "Class9englishquestion"; //
        private string localfilepaths;//The name you want to save the PDF file with
        public class9english()
        {
            InitializeComponent();
            localFilePath = Path.Combine(pdfFolderPath, pdfFileName);
            localfilepaths = Path.Combine(pdfFolderPath, engpdfquestion);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textbookpage_Click(object sender, EventArgs e)
        {
            /* string path = Path.Combine(Directory.GetCurrentDirectory(), "1852.pdf");
             Process P = new Process
             {
                 StartInfo = { FileName = "AcroRd32.exe", Arguments = path }
             };
             P.Start();
            */

            
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);

        }

        private async void InitBrowser()
        {
            await initizated();
           // webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1qFcmQ7Thmttj8kbrhTQW6JDFa5KgfWhV");
            //webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1Pe-Yekeh_5cnBrvlCVRiY9T2Ee9POl-R");
        }

        private void class9english_Load(object sender, EventArgs e)
        {
            InitBrowser();
            LoadSettings();
            Loadmodelquestion();
            //DisplayPdfFromCache();
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

        private async  void DisplayPdfFromCache()
        {
            await initizated();
            textbookpdf = Properties.Settings.Default.class9english;
            if (textbookpdf)
            {
               
                        // Load the PDF file into the WebView control.
                        webView21.CoreWebView2.Navigate(localFilePath); // You can also use the Url property if you have a direct URL to the PDF.
            }
        }
        private async void LoadSettings()
        {
            /* await initizated();

             textbookpdf = Properties.Settings.Default.class9english;
             if (textbookpdf){

                 // PDF file is already downloaded, load from the cache
                 // string cachedFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"NP Archives", "CachedFiles", @"Introduction to Information Technology Note.pdf");
                 //string projectFolderPath = Application.StartupPath;
                 //string cachedFileName = @"Introduction to Information Technology Note.pdf";
                 //string cachedFilePath = Path.Combine(projectFolderPath, cachedFileName);
                 button1.Visible = false;
                 button1.Dispose();
                 button1 = null;

                 webView21.CoreWebView2.Navigate(localFilePath);
             }
             else
             {
                 button1.Visible = true;
             }
            */
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await initizated();
            button1.Enabled = false;
            downloadandsavpdf();
            button1.Text = string.Empty;
            button1.Text += "Please wait ....";
        }

        private async void downloadandsavpdf()
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
                   
                    // Load the PDF file into the WebView control.=
                    webView21.CoreWebView2.Navigate(localFilePath); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           /* using (var httpClient = new HttpClient())
            {
                try
                {
                    // Download the PDF file from a URL
                    var pdfUrl = "https://drive.google.com/uc?export=view&id=1qFcmQ7Thmttj8kbrhTQW6JDFa5KgfWhV";
                    var response = await httpClient.GetAsync(pdfUrl);
                    response.EnsureSuccessStatusCode();

                    // Read the content of the downloaded file
                    var contentStream = await response.Content.ReadAsStreamAsync();

                    // Save the PDF file to your application's resources
                    using (var resourceWriter = new ResourceWriter(Path.Combine(Application.StartupPath, "Resources.resources")))
                    {
                        // Write the PDF content to the resource file
                        resourceWriter.AddResource("englisgtextbpook.pdf", contentStream);
                        resourceWriter.Generate();
                    }
                    button1.Visible = false;
                    button1.Dispose();
                    button1 = null;
                    webView21.CoreWebView2.Navigate(localFilePath); // You can also use the Url property if you have a direct URL to the PDF.

                    MessageBox.Show("Your IT Notes has been Downloaded. Thank Your :)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error downloading IT Notes: " + ex.Message);
                }
           */

                SaveSettings();

            
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.class9english = true;
            Properties.Settings.Default.Save();
        }

        

        private async void button2_Click(object sender, EventArgs e)
        {
            await initizated();
            button2.Enabled = false;
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

            SaveSettings();

        }
    }
}
