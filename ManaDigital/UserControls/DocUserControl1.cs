using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaDigital.UserControls
{
    public partial class DocUserControl1 : UserControl
    {
        public DocUserControl1()
        {
            InitializeComponent();
        }
        public string path = "";

      

        private void CVpictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DocUserControl1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(path)) 
            {
                var ex = Path.GetExtension(path);

                switch (ex)
                {
                    case "jpg":
                        CVpictureBox1.Image = Image.FromFile(path);
                        CVpictureBox1.Visible = true;
                        CVpdfViewer1.Visible = false;
                        break;
                    case "pdf":
                        CVpdfViewer1.DocumentFilePath = path;
                        CVpdfViewer1.Visible = true;
                        CVpictureBox1.Visible = false;



                        break;
                }
            }
        }
    }
}
