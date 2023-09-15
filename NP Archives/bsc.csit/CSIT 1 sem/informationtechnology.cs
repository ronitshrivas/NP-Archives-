using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Net.Http;
using System.Resources;

using NP_Archives.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Web.WebView2.Wpf;
using Windows.UI.WebUI;
using System.Net;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace NP_Archives.bsc.csit.CSIT_1_sem
{

    public partial class informationtechnology : Form
    {

        // private string resourceName = "NP_Archives.Resources.Introduction to Information Technology Syllabus.pdf";
        private string cacheFolderPath = "";

        private string fileUrl = "https://drive.google.com/uc?export=view&id=16HlBRZDJCVE4ak5lXw5H8NtwMA9lcIXd";

       private bool isPdfDownloaded;

        public informationtechnology()
        {
            InitializeComponent();
            // isPdfDownloaded = CheckIfPdfDownloaded();
        }

      

        private async void informationtechnology_Load(object sender, EventArgs f)
        {
            await initizated();
            InitBrowser();
           LoadSettings();
            loaditexamquestion();
        }

        private async void loaditexamquestion()
        {
            await initizated();
           
            isPdfDownloaded = Properties.Settings.Default.IsPdfDownloaded;
            if (isPdfDownloaded)
            {
                // PDF file is already downloaded, load from the cache
                // string cachedFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"NP Archives", "CachedFiles", @"Introduction to Information Technology Note.pdf");
                //string projectFolderPath = Application.StartupPath;
                //string cachedFileName = @"Introduction to Information Technology Note.pdf";
                //string cachedFilePath = Path.Combine(projectFolderPath, cachedFileName);
                questionbtn.Visible = false;
                questionbtn.Dispose();
                questionbtn = null;
                string pdfFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"1sem it question.pdf"; // The name of the cached PDF file
                string localFolderPath = Path.Combine(Application.StartupPath, "Resources.resources");
                string localFilePath;
                localFilePath = Path.Combine(localFolderPath, pdfFileName);
               // string opennotespdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"1sem it question.pdf";
                webView25.CoreWebView2.Navigate(localFilePath);
            }
            else
            {
                // PDF file needs to be downloaded
                Downloaditexamqs();
            }
        }

        private async Task initizated()
        {
            await webView24.EnsureCoreWebView2Async(null);
            //await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);
            await webView25.EnsureCoreWebView2Async(null);
            //await webView23.EnsureCoreWebView2Async(null);
        }

        private async void InitBrowser()
        {
            await initizated();
            String openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Introduction to Information Technology Syllabus.pdf";//PDF DOc name
            System.IO.File.WriteAllBytes(openPDFFile, Properties.Resources.Introduction_to_Information_Technology_Syllabus);///the resource automatically creates            
            webView24.CoreWebView2.Navigate(openPDFFile);
            //string opennotespdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Introduction to Information Technology Note.pdf";
             //System.IO.File.WriteAllBytes(opennotespdffile, Properties.Resources.Introduction_to_Information_Technology_Note);///the resource automatically creates            
            //webView22.CoreWebView2.Navigate(opennotespdffile);
            
            // webView21.NavigateToString(@"C:\C++ book.pdf");
            //webView21.CoreWebView2.Navigate(@"C:\C++ book.pdf");
            //webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=16HlBRZDJCVE4ak5lXw5H8NtwMA9lcIXd");
            // webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1q5DBGzOAlesL-SqPVpr4Azl3F3pSX-YN");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private async void button1_Click_1(object sender, EventArgs e)
        {

        }
        
        private async void LoadSettings()
        {
            await initizated();

            isPdfDownloaded = Properties.Settings.Default.IsPdfDownloaded;
            if (isPdfDownloaded)
            {
                // PDF file is already downloaded, load from the cache
                // string cachedFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"NP Archives", "CachedFiles", @"Introduction to Information Technology Note.pdf");
                //string projectFolderPath = Application.StartupPath;
                //string cachedFileName = @"Introduction to Information Technology Note.pdf";
                //string cachedFilePath = Path.Combine(projectFolderPath, cachedFileName);
                itnotesbtn.Visible = false;
                itnotesbtn.Dispose();
                itnotesbtn = null;
                string opennotespdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Introduction to Information Technology Note.pdf";
                webView22.CoreWebView2.Navigate(opennotespdffile);
            }
            else
            {
                // PDF file needs to be downloaded
                DownloadPdfFile();
            }
        }

        private async void DownloadPdfFile()
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    // Download the PDF file from a URL
                    var pdfUrl = "https://drive.google.com/uc?export=view&id=16HlBRZDJCVE4ak5lXw5H8NtwMA9lcIXd";
                    var response = await httpClient.GetAsync(pdfUrl);
                    response.EnsureSuccessStatusCode();

                    // Read the content of the downloaded file
                    var contentStream = await response.Content.ReadAsStreamAsync();

                    // Save the PDF file to your application's resources
                    using (var resourceWriter = new ResourceWriter(Path.Combine(Application.StartupPath, "Resources.resources")))
                    {
                        // Write the PDF content to the resource file
                        resourceWriter.AddResource("Introduction to Information Technology Note.pdf", contentStream);
                        resourceWriter.Generate();
                    }
                        itnotesbtn.Visible = false;
                        itnotesbtn.Dispose();
                        itnotesbtn = null;
                    MessageBox.Show("Your IT Notes has been Downloaded. Thank Your :)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error downloading IT Notes: " + ex.Message);
                }

                SaveSettings();

            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.IsPdfDownloaded = true;
            Properties.Settings.Default.Save();
        }

        private void questionbtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            questionbtn.Enabled = false;

            Downloaditexamqs();
            
        }

        private async void Downloaditexamqs()
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    // Download the PDF file from a URL
                    var pdfUrl = "https://drive.google.com/uc?export=view&id=1q5DBGzOAlesL-SqPVpr4Azl3F3pSX-YN";
                    var response = await httpClient.GetAsync(pdfUrl);
                    response.EnsureSuccessStatusCode();

                    // Read the content of the downloaded file
                    var contentStream = await response.Content.ReadAsStreamAsync();

                    // Save the PDF file to your application's resources
                    using (var resourceWriter = new ResourceWriter(Path.Combine(Application.StartupPath, "Resources.resources")))
                    {
                        // Write the PDF content to the resource file
                        resourceWriter.AddResource("1sem it question.pdf", contentStream);
                        resourceWriter.Generate();
                    }
                    questionbtn.Visible = false;
                    questionbtn.Dispose();
                    questionbtn = null;
                    MessageBox.Show("Your IT Exam Question has been Downloaded. Thank Your :)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error downloading IT Exam Question: " + ex.Message);
                }

                SaveSettingsofitquestion();
            }
        }

        private void SaveSettingsofitquestion()
        {
              Properties.Settings.Default.IsPdfDownloaded = true;
            Properties.Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void itnotesbtn_Click(object sender, EventArgs e)
        {
            itnotesbtn.Enabled = false;
            DownloadPdfFile();

        }
    }
}
