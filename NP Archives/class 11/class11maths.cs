using System;
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
    public partial class class11maths : Form
    {
        private string pdfUrl = "https://drive.google.com/uc?export=view&id=1R7Etn-Q_P-kp5TlCJydzzWwZ2nJJtnjN";
        private string pdfFileName = "class11mathstextbook1"; // The name you want to save the PDF file with
        private string pdfFolderPath = Path.Combine(Application.StartupPath, "DownloadedPDFs");
        private string localFilePath;
        private string engpdfUrl = "https://drive.google.com/uc?export=view&id=1LHKjIf5rtwyiKkyS8FSovLtGuOqIkXat";
        private string engpdfquestion = "class11mathstextbook2"; //
        private string localfilepaths;
        private string pdfurlpart3 = "https://drive.google.com/uc?export=view&id=1H3JlMts7OFtu6pg_Tednd9JsdOrvtBcP";
        private string pdffilname = "class11mathsoldisgoldsol1"; //
        private string localfilepath3;
        private string pdfurlpart4 = "https://drive.google.com/uc?export=view&id=1KueJ35v46XMZPUMEel593s5HU2FtMFZl";
        private string pdffilname4 = "class11mathsoldisgoldsol2"; //
        private string localfilepath4;
        private string pdfurlpart5 = "https://drive.google.com/uc?export=view&id=1x3z67nOcX3Q5XfwBfSBBoXclDOcJqw9Y";
        private string pdffilname5 = "class11mathsoldisgoldsol3"; //
        private string localfilepath5;
        private string pdfurlpart6 = "https://drive.google.com/uc?export=view&id=1y4AUioQB6qoS9tRkYAUPVCXgp4l9bwaD";
        private string pdffilname6 = "class11mathsmodelquestionsol"; //
        private string localfilepath6;
        private string pdfurlpart7 = "https://drive.google.com/uc?export=view&id=1nQ7PqeHmeiNq99EFkS3j-6jBuTpicTN_";
        private string pdffilname7 = "class11mathsmodelpaper"; //
        private string localfilepath7;
        public class11maths()
        {
            InitializeComponent();
            localFilePath = Path.Combine(pdfFolderPath, pdfFileName);
            localfilepaths = Path.Combine(pdfFolderPath, engpdfquestion);
            localfilepath3 = Path.Combine(pdfFolderPath, pdffilname);
            localfilepath4 = Path.Combine(pdfFolderPath, pdffilname4);
            localfilepath5 = Path.Combine(pdfFolderPath, pdffilname5);
            localfilepath6 = Path.Combine(pdfFolderPath, pdffilname6);
            localfilepath7 = Path.Combine(pdfFolderPath, pdffilname7);

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void InitBrowser()
        {
            await initizated();
            //webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1R7Etn-Q_P-kp5TlCJydzzWwZ2nJJtnjN");
          //  webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1LHKjIf5rtwyiKkyS8FSovLtGuOqIkXat");
         //   webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1H3JlMts7OFtu6pg_Tednd9JsdOrvtBcP");
            //webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1KueJ35v46XMZPUMEel593s5HU2FtMFZl");
           // webView25.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1x3z67nOcX3Q5XfwBfSBBoXclDOcJqw9Y");
          //  webView26.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1y4AUioQB6qoS9tRkYAUPVCXgp4l9bwaD");
           // webView27.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1nQ7PqeHmeiNq99EFkS3j-6jBuTpicTN_");
        }
        private void class11maths_Load(object sender, EventArgs e)
        {
            InitBrowser();
            loadtextbook1();
            loadtextbook2();
            loadquestionbanksoln1();
            loadquestionbanksoln2();
            loadquestionbanksoln3();
            loadmodelquestionsoln();
            loadquestionpaper();

        }

        private async void loadquestionpaper()
        {
            await initizated();
            if (File.Exists(localfilepath7))
            {
                try
                {
                    button7.Visible = false;
                    button7.Dispose();
                    button7 = null;

                    // Load the PDF file into the WebView control.
                    webView27.CoreWebView2.Navigate(localfilepath7); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button7.Visible = true;
                }
            }
        }

        private async void loadmodelquestionsoln()
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
                    webView26.CoreWebView2.Navigate(localfilepath6); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button6.Visible = true;
                }
            }
        }

        private async void loadquestionbanksoln3()
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
                    webView25.CoreWebView2.Navigate(localfilepath5); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button5.Visible = true;
                }
            }
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
                    webView24.CoreWebView2.Navigate(localfilepath4); // You can also use the Url property if you have a direct URL to the PDF.
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
                    webView23.CoreWebView2.Navigate(localfilepath3); // You can also use the Url property if you have a direct URL to the PDF.
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
                    webView22.CoreWebView2.Navigate(localfilepaths); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button2.Visible = true;
                }
            }



            
        }

        private async void loadtextbook1()
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

      

        private async void button1_Click(object sender, EventArgs e)
        {
            await initizated();
            button1.Enabled = false;
            downloadtextbpook1();
            button1.Text = string.Empty;
            button1.Text += "Please wait ....";
        }

        private async void downloadtextbpook1()
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
            button2.Enabled = false;
            downloadtextbook2();
            button2.Text = string.Empty;
            button2.Text += "Please wait ....";
        }

        private async void downloadtextbook2()
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

        private async void button3_Click(object sender, EventArgs e)
        {
            await initizated();
            button3.Enabled = false;
            downloadmodelquestionsol1();
            button3.Text = string.Empty;
            button3.Text += "Please wait ....";
        }

        private async void downloadmodelquestionsol1()
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

                    // Load the PDF file into the WebView control.
                    webView23.CoreWebView2.Navigate(localfilepath3); // You can also use the Url property if you have a direct URL to the PDF.
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
            downloadmodelquestionsol2();
            button4.Text = string.Empty;
            button4.Text += "Please wait ....";
        }

        private async void downloadmodelquestionsol2()
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
                    webView24.CoreWebView2.Navigate(localfilepath4); // You can also use the Url property if you have a direct URL to the PDF.
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
            downloadoldisgoldsoln3();
            button5.Text = string.Empty;
            button5.Text += "Please wait ....";
        }

        private async void downloadoldisgoldsoln3()
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
                    byte[] pdfData = await client.GetByteArrayAsync(pdfurlpart5);
                    File.WriteAllBytes(localfilepath5, pdfData);
                    //Note Ronit that if pdf is downloaded then button will hide
                    button5.Visible = false;
                    button5.Dispose();
                    button5 = null;

                    // Load the PDF file into the WebView control.
                    webView25.CoreWebView2.Navigate(localfilepath5); // You can also use the Url property if you have a direct URL to the PDF.
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
            donwloadmodelquestion();
            button6.Text = string.Empty;
            button6.Text += "Please wait ....";
        }

        private async void donwloadmodelquestion()
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
                    byte[] pdfData = await client.GetByteArrayAsync(pdfurlpart6);
                    File.WriteAllBytes(localfilepath6, pdfData);
                    //Note Ronit that if pdf is downloaded then button will hide
                    button6.Visible = false;
                    button6.Dispose();
                    button6 = null;

                    // Load the PDF file into the WebView control.
                    webView26.CoreWebView2.Navigate(localfilepath6); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            await initizated();
            button7.Enabled = false;
            downloadmodelpaper();
            button7.Text = string.Empty;
            button7.Text += "Please wait ....";
        }

        private async void downloadmodelpaper()
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
                    byte[] pdfData = await client.GetByteArrayAsync(pdfurlpart7);
                    File.WriteAllBytes(localfilepath7, pdfData);
                    //Note Ronit that if pdf is downloaded then button will hide
                    button7.Visible = false;
                    button7.Dispose();
                    button7 = null;

                    // Load the PDF file into the WebView control.
                    webView27.CoreWebView2.Navigate(localfilepath7); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
