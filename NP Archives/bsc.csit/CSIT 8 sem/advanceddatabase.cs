using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_8_sem
{
    public partial class advanceddatabase : Form
    {
        private string pdfUrl = "https://drive.google.com/uc?export=view&id=1b-i-lmQKBUrwsW0bzqYT3qTYheDThQ6P";
        private string pdfFileName = "csit8semadvanceddatabasechapterwisenotes"; // The name you want to save the PDF file with
        private string pdfFolderPath = Path.Combine(Application.StartupPath, "DownloadedPDFs");
        private string localFilePath;
        private string engpdfUrl = "https://drive.google.com/uc?export=view&id=1kEW3nU0fXs0sDDX3IbjO6-9Cw2z0Hgbj";
        private string engpdfquestion = "csit8semadvanceddatabasemodelquestion"; //
        private string localfilepaths;
        private string pdfurlpart3 = "https://drive.google.com/uc?export=view&id=1pjPiwFDK-T8OjQQQslsCwaYsdgPD4lOa";
        private string pdffilname = "csit8semadvanceddatabaseexamquestion"; //
        private string localfilepath3;
        private string pdfurlpart4 = "https://drive.google.com/uc?export=view&id=1XHyIEsy0Adbu_FnpC2AXhdcNdHml35BR";
        private string pdffilname4 = "csit8semadvanceddatabasenote"; //
        private string localfilepath4;
        private string pdfurlpart5 = "https://drive.google.com/uc?export=view&id=1mYYdel4py6AQboYEpuQQur-jfC-O1l35";
        private string pdffilname5 = "csit8semadvanceddatabaseintroductionofdb"; //
        private string localfilepath5;
        private string pdfurlpart6 = "https://drive.google.com/uc?export=view&id=1MjmWeqRFGphkGRRKl_3TEHzc4o80g0Iy";
        private string pdffilname6 = "csit8semadvanceddatabasefundamentalofdb"; //
        private string localfilepath6;
        public advanceddatabase()
        {
            InitializeComponent();
            localFilePath = Path.Combine(pdfFolderPath, pdfFileName);
            localfilepaths = Path.Combine(pdfFolderPath, engpdfquestion);
            localfilepath3 = Path.Combine(pdfFolderPath, pdffilname);
            localfilepath4 = Path.Combine(pdfFolderPath, pdffilname4);
            localfilepath5 = Path.Combine(pdfFolderPath, pdffilname5);
            localfilepath6 = Path.Combine(pdfFolderPath, pdffilname6);

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
            await webView26.EnsureCoreWebView2Async(null);
            await webView27.EnsureCoreWebView2Async(null);

        }

        private async void InitBrowser()
        {
            await initizated();
            String openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Advanced Database syllabus.pdf";//PDF DOc name
            System.IO.File.WriteAllBytes(openPDFFile, Properties.Resources.Advanced_Database_syllabus);///the resource automatically creates            
            webView21.CoreWebView2.Navigate(openPDFFile);
            //webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1Sax8OnYlBJcdCk3dbbzewxx2QyYnrf1Q");
        }

        private void advanceddatabase_Load(object sender, EventArgs e)
        {
            InitBrowser();
            loadnotechapterwise();
            loadmodelquestion();
            loadexamquestion();
            loadnote();
            loadintroductionofdb();
            loadfundamentaldb();
        }

       

        private async  void loadfundamentaldb()
        {
            await initizated();
            if (File.Exists(localfilepath6))
            {
                try
                {
                    button6.Visible = false;
                    button6.Dispose();
                    button6 = null;

                    // Load the PDF file into the WebView control.
                    webView27.CoreWebView2.Navigate(localfilepath6); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button6.Visible = true;
                }
            }
        }

        private async void loadintroductionofdb()
        {
            await initizated();
            if (File.Exists(localfilepath5))
            {
                try
                {
                    button5.Visible = false;
                    button5.Dispose();
                    button5 = null;

                    // Load the PDF file into the WebView control.
                    webView26.CoreWebView2.Navigate(localfilepath5); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button5.Visible = true;
                }
            }
        }
        private async void loadnote()
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
        private async void loadexamquestion()
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

        private async void loadmodelquestion()
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

        private async void loadnotechapterwise()
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

        private async void button1_Click(object sender, EventArgs e)
        {
            await initizated();
            button1.Enabled = false;

            downloadnotechapterwise();
            button1.Text = string.Empty;
            button1.Text += "Please wait ....";
        }

        private async void downloadnotechapterwise()
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

        private async void button3_Click(object sender, EventArgs e)
        {
            await initizated();
            button3.Enabled = false;

            downloadexamquestion();
            button3.Text = string.Empty;
            button3.Text += "Please wait ....";
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

        private async void button4_Click(object sender, EventArgs e)
        {
            await initizated();
            button4.Enabled = false;
            downloadnote();
            button4.Text = string.Empty;
            button4.Text += "Please wait ....";
        }

        private async void downloadnote()
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

        private async void button5_Click(object sender, EventArgs e)
        {
            await initizated();
            button5.Enabled = false;
            downloadintroductionofdb();
            button5.Text = string.Empty;
            button5.Text += "Please wait ....";
        }

        private async void downloadintroductionofdb()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(300);
                    // Create the PDF folder if it doesn't exist.
                    if (!Directory.Exists(pdfFolderPath))
                        Directory.CreateDirectory(pdfFolderPath);

                    // Download the PDF file and save it to the PDF folder.
                    byte[] pdfData = await client.GetByteArrayAsync(pdfurlpart5);
                    File.WriteAllBytes(localfilepath5, pdfData);
                    //Note Ronit that if pdf is downloaded then button will hide
                    button5.Visible = false;
                    button5.Dispose();
                    button5 = null;

                    // Load the PDF file into the WebView control.
                    await initizated();

                    webView26.CoreWebView2.Navigate(localfilepath5); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            await initizated();
            button6.Enabled = false;
            downloadfundamentalofdb();
            button6.Text = string.Empty;
            button6.Text += "Please wait ....";
        }

        private async void downloadfundamentalofdb()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(300);
                    // Create the PDF folder if it doesn't exist.
                    if (!Directory.Exists(pdfFolderPath))
                        Directory.CreateDirectory(pdfFolderPath);

                    // Download the PDF file and save it to the PDF folder.
                    byte[] pdfData = await client.GetByteArrayAsync(pdfurlpart6);
                    File.WriteAllBytes(localfilepath6, pdfData);
                    //Note Ronit that if pdf is downloaded then button will hide
                    button6.Visible = false;
                    button6.Dispose();
                    button6 = null;

                    // Load the PDF file into the WebView control.
                    await initizated();

                    webView27.CoreWebView2.Navigate(localfilepath6); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
