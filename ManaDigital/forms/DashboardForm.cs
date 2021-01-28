using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaDigital
{
    public partial class DashboardForm : Form
    {
        public Panel Master;
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            Motherpanel1.Controls.Clear();
            Motherpanel1.Controls.Add(registerUserControl11);
            Master = Motherpanel1;

        }

        private void Registerbutton1_Click(object sender, EventArgs e)
        {
            Motherpanel1.Controls.Clear();
            Motherpanel1.Controls.Add(registerUserControl11);
        }

        private void SearchEditbutton2_Click(object sender, EventArgs e)
        {
            Motherpanel1.Controls.Clear();
            Motherpanel1.Controls.Add(searchEditUserControl11);

        }

        private void Groupsbutton3_Click(object sender, EventArgs e)
        {
            Motherpanel1.Controls.Clear();
            Motherpanel1.Controls.Add(makeGroupUserControl11);
        }

        private void makeGroupUserControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
