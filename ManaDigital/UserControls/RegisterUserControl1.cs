using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntity;
using System.Data.SqlClient;
using dataAccess;
using System.IO;

namespace ManaDigital
{
    public partial class RegisterUserControl1 : UserControl
    {
        public RegisterUserControl1()
        {
            InitializeComponent();
        }
       // SqlConnection CON = new SqlConnection("Data Source=.;Initial Catalog=royadb;Integrated Security=True");
        string path = "";
        bool search(person p)
        {
            phbContext phb = new phbContext();
            return phb.persons.Any(i => i.fullName.Contains(p.fullName));
        }
        void register(person p, personDetail pd, personPhone pp)
        {
            phbContext db1 = new phbContext();
            if (p.Age >= 18 && search(p) != true)
            {
                db1.persons.Add(new person { fullName = p.fullName, relation = p.relation, Age = p.Age, Image = path });
                db1.personDetails.Add(new personDetail {parameter=pd.parameter , Address = pd.Address });
               db1.phopersonPhones.Add(new personPhone { phoneNumber = pp.phoneNumber });
                db1.SaveChanges();

                
                MessageBox.Show("ثبت نام شما موفقیت آمیز بود");
                

            }
            else
            {
                MessageBox.Show("امکان ثبت نام وجود ندارد");
            }
        }

        private void Relationlabel2_Click(object sender, EventArgs e)
        {

        }

        private void Agelabel5_Click(object sender, EventArgs e)
        {

        }

        private void Submitbutton2_Click(object sender, EventArgs e)
        {
            register(
               
               new person
               {
                   fullName = NamebunifuMaterialTextbox1.Text,
                   Age = Convert.ToInt32(AgenumericUpDown1.Value),
                   relation = RelationbunifuMaterialTextbox1.Text,
                  
               },
           new personDetail {  Address = AddressbunifuMaterialTextbox1.Text },
           new personPhone { phoneNumber = PhonebunifuMaterialTextbox1.Text }
           
           );
        }

        private void RegisterUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void ChooseFilebutton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select file to be upload.";
            openFileDialog1.Filter = "Select Valid Document(*.pdf; *.doc; *.xlsx; *.html; *.jpg; *.svg; )|*.pdf; *.docx; *.xlsx; *.html *.jpg; *.svg;";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        //path = Path.Combine(Directory.GetCurrentDirectory(), "docs", DateTime.Now.Ticks.ToString() + Path.GetExtension(openFileDialog1.FileName));
                        //var img = File.OpenRead(openFileDialog1.FileName);

                        //FileStream fileStream = File.Create(path, (int)img.Length);
                        //byte[] bytesInStream = new byte[img.Length];
                        //img.Read(bytesInStream, 0, bytesInStream.Length);
                        //fileStream.Write(bytesInStream, 0, bytesInStream.Length);
                        //fileStream.Close();
                    }
                }
                else
                {
                    MessageBox.Show("فایل مورد نظر را انتخاب کنید");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CVSaverbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                Image img = Bitmap.FromFile(filename);
                //path = Path.Combine(Directory.GetCurrentDirectory(), "docs", DateTime.Now.Ticks.ToString() + Path.GetExtension(filename));

                //img.Save(path);




                //if (filename == null)
                //{
                //    MessageBox.Show("Please select a valid document.");
                //}
                //else
                //{
                //    //we already define our connection globaly. We are just calling the object of connection.
                //    CON.Open();
                //    SqlCommand cmd = new SqlCommand("insert into doc (document)values(path)", CON);
                //    cmd.ExecuteNonQuery();s
                //    CON.Close();
                //    MessageBox.Show("Document uploaded.");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
