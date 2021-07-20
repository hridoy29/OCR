using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;

namespace OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = string.Empty;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "*pdf files|*.pdf";
            if (file.ShowDialog() == DialogResult.OK)
            {
                
                
                path = file.FileName;
                pdfViewer1.LoadFromFile(path);

            }
        }

        [Obsolete]
        private void btnSubmit_Click(object sender, EventArgs e)
        {
             
             
            var ocr = new AutoOcr();
            textBox1.Text = ocr.ReadPdf(pdfViewer1.FileName).Text.ToString();

        }
    }
}
