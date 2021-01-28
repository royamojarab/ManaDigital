using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ManaDigital
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection();

        public LoginForm()
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=(local);Initial Catalog=royadb;Integrated Security=true";
            InitializeComponent();
        }
        

        private void LoginForm_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=(local);Initial Catalog=royadb;Integrated Security=true";
            con.Open();

        }

        private void Exitbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
          
    }

        private void Loginbutton1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=(local);Initial Catalog=royadb;Integrated Security=true";
            //con.Open();
            //string userid = UserNamebunifuMaterialTextbox1.Text;
            //string password = PasswordbunifuMaterialTextbox2.Text;
            //SqlCommand cmd = new SqlCommand("select userid,password from login where userid='" + UserNamebunifuMaterialTextbox1.Text + "'and password='" + PasswordbunifuMaterialTextbox2.Text + "'", con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("کاربر" + UserNamebunifuMaterialTextbox1.Text + "شما با موفقیت وارد شدید");
            //    DashboardForm D1 = new DashboardForm();
            //    D1.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
            //}
            //con.Close();

        }

        private void UserNamebunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordbunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
    }
