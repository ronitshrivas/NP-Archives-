using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.bsc.csit.CSIT_3_sem
{
    public partial class datastructurealgorithm : Form
    {

        private string pdfUrl = "https://drive.google.com/uc?export=view&id=1GZz-WIg63bZgy38igE2MS0QfEfDEHv2s";
        private string pdfFileName = "csit3rdsemdsanotes"; // The name you want to save the PDF file with
        private string pdfFolderPath = Path.Combine(Application.StartupPath, "DownloadedPDFs");
        private string localFilePath;
        private string engpdfUrl = "https://drive.google.com/uc?export=view&id=1V1sX28diYqGmqt3mGljuAj0O5zRMb2Tq";
        private string engpdfquestion = "csit3rdsemdsaexamquestion"; //
        private string localfilepaths;
        private string pdfurlpart3 = "https://drive.google.com/uc?export=view&id=1VNpL4CjytGsPDFrpbZeA31-BMe6GusYG";
        private string pdffilname = "csit3rdsemdsalabwork"; //
        private string localfilepath3;
        private string pdfurlpart4 = "https://drive.google.com/uc?export=view&id=19IK9OiXkmVuMsWLAthELg3E5Man5eawY";
        private string pdffilname4 = "csit3rdsemdsatextbook"; //
        private string localfilepath4;
        private string pdfurlpart5 = "https://drive.google.com/uc?export=view&id=1jkRMFmuERcRLbNZuApJBDhpVo1tqt2LE";
        private string pdffilname5 = "csit3rdsemdsaoldisgoldsoln"; //
        private string localfilepath5;
        public datastructurealgorithm()
        {
            InitializeComponent();
            localFilePath = Path.Combine(pdfFolderPath, pdfFileName);
            localfilepaths = Path.Combine(pdfFolderPath, engpdfquestion);
            localfilepath3 = Path.Combine(pdfFolderPath, pdffilname);
            localfilepath4 = Path.Combine(pdfFolderPath, pdffilname4);
            localfilepath5 = Path.Combine(pdfFolderPath, pdffilname5);
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

        }

        private async void InitBrowser()
        {
            await initizated();
            String openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Data Structures and Algorithms Syllabus.pdf";//PDF DOc name
            System.IO.File.WriteAllBytes(openPDFFile, Properties.Resources.Data_Structures_and_Algorithms_Syllabus);///the resource automatically creates            
            webView21.CoreWebView2.Navigate(openPDFFile);
            /*
            string opennotespdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Data Structure and Algorithm Notes by Bhpendra Saud.pdf";
          //  System.IO.File.WriteAllBytes(opennotespdffile, Properties.Resources.Data_Structure_and_Algorithm_Notes_by_Bhpendra_Saud);///the resource automatically creates            
            webView22.CoreWebView2.Navigate(opennotespdffile);
            string openexampdffile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"DSA Exam Question 3rd sem.pdf";
           // System.IO.File.WriteAllBytes(openexampdffile, Properties.Resources.DSA_Exam_Question_3rd_sem);///the resource automatically creates            
            webView23.CoreWebView2.Navigate(openexampdffile);
            string labassignment = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"Lab Assignment.pdf";
         //   System.IO.File.WriteAllBytes(labassignment, Properties.Resources.Lab_Assignment);///the resource automatically creates            
            webView24.CoreWebView2.Navigate(labassignment);
            */
            // webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1kDMatUu6WjvQW4qe5eyoiJGrbBIhoqja");
            //webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1GZz-WIg63bZgy38igE2MS0QfEfDEHv2s");
            //webView23.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1V1sX28diYqGmqt3mGljuAj0O5zRMb2Tq");
            //webView24.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1VNpL4CjytGsPDFrpbZeA31-BMe6GusYG");
        }


        private void datastructurealgorithm_Load(object sender, EventArgs e)
        {
            InitBrowser();
            loadnotes();
            loadexamquestion();
            loadlabassignmnet();
            loadtextbook();
            loadoldisgoldsoln();

        }

        private async void loadoldisgoldsoln()
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

        private async void loadlabassignmnet()
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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            downloadnotes();
            button1.Text = string.Empty;
            button1.Text += "Please wait ....";
        }

        private async void downloadnotes()
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

            downloadexamquestion();
            button2.Text = string.Empty;
            button2.Text += "Please wait ....";
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

            downloadlabassignment();
            button3.Text = string.Empty;
            button3.Text += "Please wait ....";
        }

        private async void downloadlabassignment()
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
            downloadtextbook();

            button4.Enabled = false;
            button4.Text = string.Empty;
            button4.Text += "Please wait ....";
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
            button5.Text = string.Empty;
            button5.Text += "Please wait ....";
            downloadoldissoln();
        }

        private async void downloadoldissoln()
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
    }
}
