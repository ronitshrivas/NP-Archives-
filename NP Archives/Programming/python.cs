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
    public partial class python : Form
    {
        public python()
        {
            InitializeComponent();
        }

        private void python_Load(object sender, EventArgs e)
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
            webView21.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=10-ofLfGS069UO0PdMKi1oIzAVafNZrN_");
            webView22.CoreWebView2.Navigate("https://drive.google.com/uc?export=view&id=1vorhpsJPGN1FI0HXH8jfKpGJdSQ0naJk");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
