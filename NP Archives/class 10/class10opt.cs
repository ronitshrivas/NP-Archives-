using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_Archives.class_10
{
    public partial class class10opt : Form
    {
        private string pdfUrl = "https://drive.google.com/uc?export=view&id=1wEUcY3rut4e4_43NxES6xOayHr6JejTy";
        private string pdfFileName = "class10opttextbook"; // The name you want to save the PDF file with
        private string pdfFolderPath = Path.Combine(Application.StartupPath, "DownloadedPDFs");
        private string localFilePath;
        private string engpdfUrl = "https://drive.google.com/uc?export=view&id=1pDL1QGfOxO-Z2gC1vejeHz3gDl8mkQ43";
        private string engpdfquestion = "class10optmodelquestion"; //
        private string localfilepaths;
        private string pdfurlpart3 = "https://drive.google.com/uc?export=view&id=1hxZl9KB-lLg_Xsk4oAIKTX9nFqyjXY_t";
        private string pdffilname = "class10samplequestion"; //
        private string localfilepath3;
        public class10opt()
        {
            InitializeComponent();
            localFilePath = Path.Combine(pdfFolderPath, pdfFileName);
            localfilepaths = Path.Combine(pdfFolderPath, engpdfquestion);
            localfilepath3 = Path.Combine(pdfFolderPath, pdffilname);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void class10opt_Load(object sender, EventArgs e)
        {

        }
    }
}
