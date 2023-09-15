using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.class_12
{
    public partial class class12botany : Form
    {
        private string pdfUrl = "https://drive.google.com/uc?export=view&id=1VJ0kZJ17s-5FqOOpfFwAfiF7z6F_fkaz";
        private string pdfFileName = "class12botanypracticalcopy"; // The name you want to save the PDF file with
        private string pdfFolderPath = Path.Combine(Application.StartupPath, "DownloadedPDFs");
        private string localFilePath;
        public class12botany()
        {
            InitializeComponent();
            localFilePath = Path.Combine(pdfFolderPath, pdfFileName);

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task initizated()
        {
            
            await webView24.EnsureCoreWebView2Async(null);


        }

        private async void InitBrowser()
        {
            await initizated();
           
            webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1VJ0kZJ17s-5FqOOpfFwAfiF7z6F_fkaz");
        }

        private void class12botany_Load(object sender, EventArgs e)
        {
            InitBrowser();
            LoadSettings();

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
                    webView24.CoreWebView2.Navigate(localFilePath); // You can also use the Url property if you have a direct URL to the PDF.
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
            downloadpracticalcopy();
            button1.Text = string.Empty;
            button1.Text += "Please wait ....";
        }

        private async void downloadpracticalcopy()
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
                    webView24.CoreWebView2.Navigate(localFilePath); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
