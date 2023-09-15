using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.Programming
{
    public partial class javascript : Form
    {
        public javascript()
        {
            InitializeComponent();
        }

        private void javascript_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);
        }

        private async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1-JL3R-WBWNNJOkW9PxT_ESxxkomK7tXy");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1WOrb2eKFsUgZg6a7nks4t4J00aKI8L7F");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
