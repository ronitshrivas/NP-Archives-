using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_5_sem
{
    public partial class webtechnology : Form
    {
        private string pdfUrl = "https://drive.google.com/uc?export=view&id=1RxWpQB9hXFMRj7IbkZMNNgLu14AuepaC";
        private string pdfFileName = "csit5semwebtechnologynotes"; // The name you want to save the PDF file with
        private string pdfFolderPath = Path.Combine(Application.StartupPath, "DownloadedPDFs");
        private string localFilePath;
        private string engpdfUrl = "https://drive.google.com/uc?export=view&id=1wo7ZpwT52A-O_gzai4fnJJD4DGoD_BpG";
        private string engpdfquestion = "csit5semwebtechnologyexamquestion"; //
        private string localfilepaths;
        private string pdfurlpart3 = "https://drive.google.com/uc?export=view&id=1PX7A2Rf_DETOseUqbUU03lLmpzAjtn4h";
        private string pdffilname = "csit5semwebtechnologyhtmlandcssrefernce"; //
        private string localfilepath3;
        private string pdfurlpart4 = "https://drive.google.com/uc?export=view&id=1fsc_O2nyExT72DuH_AOX8KFQ7cIItefy";
        private string pdffilname4 = "csit5semwebtechnologyjavascript5edition"; //
        private string localfilepath4;
        private string pdfurlpart5 = "https://drive.google.com/uc?export=view&id=1Sbu9Kg2FW0dO5Gf4j7kZW2jUSROqDuPv";
        private string pdffilname5 = "csit5semwebtechnologyhtml5andcss3"; //
        private string localfilepath5;
        private string pdfurlpart6 = "https://drive.google.com/uc?export=view&id=1tn8ykeBKgYxPBetRcB8HcMWeETh6LU5u";
        private string pdffilname6 = "csit5semwebtechnologywbtchnolgies"; //
        private string localfilepath6;
        private string pdfurlpart7 = "https://drive.google.com/uc?export=view&id=1_MFOY7dzn6pVxzW-TwGb7GC4euNybOX-";
        private string pdffilname7 = "csit5semwebtechnologyhtmlandcssdesign"; //
        private string localfilepath7;
        private string pdfurlpart8 = "https://drive.google.com/uc?export=view&id=1C_pyp39rXJGMnmKv4_Lysnz6R32-Jtlm";
        private string pdffilname8 = "csit5semwebtechnologyphpandmysql"; //
        private string localfilepath8;
        private string pdfurlpart9 = "https://drive.google.com/uc?export=view&id=1LtKYR5ttvdW52gLnjJPqLVdm2j90XQSb";
        private string pdffilname9 = "csit5semwebtechnologyjquery"; //
        private string localfilepath9;
        public webtechnology()
        {
            InitializeComponent();
            localFilePath = Path.Combine(pdfFolderPath, pdfFileName);
            localfilepaths = Path.Combine(pdfFolderPath, engpdfquestion);
            localfilepath3 = Path.Combine(pdfFolderPath, pdffilname);
            localfilepath4 = Path.Combine(pdfFolderPath, pdffilname4);
            localfilepath5 = Path.Combine(pdfFolderPath, pdffilname5);
            localfilepath6 = Path.Combine(pdfFolderPath, pdffilname6);
            localfilepath7 = Path.Combine(pdfFolderPath, pdffilname7);
            localfilepath8 = Path.Combine(pdfFolderPath, pdffilname8);
            localfilepath9 = Path.Combine(pdfFolderPath, pdffilname9);
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
            await webView28.EnsureCoreWebView2Async(null);
            await webView29.EnsureCoreWebView2Async(null);
            await webView30.EnsureCoreWebView2Async(null);


        }

        private async void InitBrowser()
        {
            await initizated();
            String openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Cryptography Syllabus.pdf";//PDF DOc name
            System.IO.File.WriteAllBytes(openPDFFile, Properties.Resources.Cryptography_Syllabus);///the resource automatically creates            
            webView21.CoreWebView2.Navigate(openPDFFile);
            /*
            string opennotespdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Cryptography Note by Bikash Balami.pdf";
           // System.IO.File.WriteAllBytes(opennotespdffile, Properties.Resources.Cryptography_Note_by_Bikash_Balami);///the resource automatically creates            
            webView22.CoreWebView2.Navigate(opennotespdffile);
            string openexampdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Cryptography Exam Question 5 sem.pdf";
          //  System.IO.File.WriteAllBytes(openexampdffile, Properties.Resources.Cryptography_Exam_Question_5_sem);///the resource automatically creates            
            webView23.CoreWebView2.Navigate(openexampdffile);
            */
            //webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1wJYSgU38PbJOhmMhe5FO_N_1AT6nAkZ4");
            //webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1RxWpQB9hXFMRj7IbkZMNNgLu14AuepaC");
            //webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1wo7ZpwT52A-O_gzai4fnJJD4DGoD_BpG");
        }

        private void webtechnology_Load(object sender, EventArgs e)
        {
            InitBrowser();
            loadnotes();
            loadexamquestion();
            loadhtmlandcssrefernce();
            loadjavascript5edition();
            loadhtml5andcss3();
            loadwebtechnologies();
            loadhtmlandcssdesign();
            loadphpandmysql();
            loadjquery();
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

        private async void loadhtmlandcssrefernce()
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

        private async void loadjavascript5edition()
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

        private async void loadhtml5andcss3()
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

        private async void loadwebtechnologies()
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

        private async void loadhtmlandcssdesign()
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
                    webView28.CoreWebView2.Navigate(localfilepath7); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button7.Visible = true;
                }
            }
        }

        private async void loadphpandmysql()
        {
            await initizated();
            if (File.Exists(localfilepath8))
            {
                try
                {
                    button8.Visible = false;
                    button8.Dispose();
                    button8 = null;

                    // Load the PDF file into the WebView control.
                    webView29.CoreWebView2.Navigate(localfilepath8); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button8.Visible = true;
                }
            }
        }

        private async void loadjquery()
        {
            await initizated();
            if (File.Exists(localfilepath9))
            {
                try
                {
                    button9.Visible = false;
                    button9.Dispose();
                    button9 = null;

                    // Load the PDF file into the WebView control.
                    webView30.CoreWebView2.Navigate(localfilepath9); // You can also use the Url property if you have a direct URL to the PDF.
                }
                catch (Exception ex)
                {
                    button9.Visible = true;
                }
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
            downloadhtmlandcssrefernce();
            button3.Text = string.Empty;
            button3.Text += "Please wait ....";
        }

        private async void downloadhtmlandcssrefernce()
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
            downloadjavascript();
            button4.Text = string.Empty;
            button4.Text += "Please wait ....";
        }

        private async void downloadjavascript()
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
            downloadhtml5andcss3();
            button5.Text = string.Empty;
            button5.Text += "Please wait ....";
        }

        private async void downloadhtml5andcss3()
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

            downloadwebtechnologies();
            button6.Text = string.Empty;
            button6.Text += "Please wait ....";
        }

        private async void downloadwebtechnologies()
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
                    webView27.CoreWebView2.Navigate(localfilepath6); // You can also use the Url property if you have a direct URL to the PDF.
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

            DownloadhtmlandcssDesign();
            button7.Text = string.Empty;
            button7.Text += "Please wait ....";
        }

        private async void DownloadhtmlandcssDesign()
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
                    webView28.CoreWebView2.Navigate(localfilepath7); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            await initizated();
            button8.Enabled = false;

            downloadphpandsql();
            button8.Text = string.Empty;
            button8.Text += "Please wait ....";
        }

        private async void downloadphpandsql()
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
                    byte[] pdfData = await client.GetByteArrayAsync(pdfurlpart8);
                    File.WriteAllBytes(localfilepath8, pdfData);
                    //Note Ronit that if pdf is downloaded then button will hide
                    button8.Visible = false;
                    button8.Dispose();
                    button8 = null;

                    // Load the PDF file into the WebView control.
                    webView29.CoreWebView2.Navigate(localfilepath8); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            await initizated();
            button9.Enabled = false;

            downloadjquery();
            button9.Text = string.Empty;
            button9.Text += "Please wait ....";
        }

        private async void downloadjquery()
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
                    byte[] pdfData = await client.GetByteArrayAsync(pdfurlpart9);
                    File.WriteAllBytes(localfilepath9, pdfData);
                    //Note Ronit that if pdf is downloaded then button will hide
                    button9.Visible = false;
                    button9.Dispose();
                    button9 = null;

                    // Load the PDF file into the WebView control.
                    webView30.CoreWebView2.Navigate(localfilepath9); // You can also use the Url property if you have a direct URL to the PDF.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
