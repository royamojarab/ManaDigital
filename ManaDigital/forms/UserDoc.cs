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

namespace ManaDigital.forms
{
    public partial class UserDoc : Form
    {
        public UserDoc()
        {
            InitializeComponent();
        }
        public string path = "";

        public void UserDoc_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(path))
            {
                var ex = Path.GetExtension(path);

                switch (ex)
                {
                    case "jpg":
                        pictureBox1.Image = Image.FromFile(path);
                        pictureBox1.Visible = true;
                        pdfViewer1.Visible = false;
                        break;
                    case "pdf":
                        pdfViewer1.DocumentFilePath = path;
                        pdfViewer1.Visible = true;
                        pictureBox1.Visible = false;



                        break;
                }
            }
        }
    }
}
