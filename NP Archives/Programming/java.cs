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
    public partial class java : Form
    {
        public java()
        {
            InitializeComponent();
        }

        private void java_Load(object sender, EventArgs e)
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1j9qjRoWbyborXNnl_5xrDomrm107YiEg");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=171wqoFlXflsQDe88Cp7ezQ91OPYpIFnb");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
