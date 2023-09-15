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
    public partial class php : Form
    {
        public php()
        {
            InitializeComponent();
        }

        private void php_Load(object sender, EventArgs e)
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1AvNFrUArQKuuBQzapayMqjM1dmACkMxd");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1elqI1qoImVs0BtkbU6iktOb6IlHaPEhv");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
