using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            if(txtEmail.Text.ToUpper() == "ADMIN")
            {
                this.Hide();
                var adminDashboard = new Admin_Dashboard();
                adminDashboard.Closed += (s, args) => this.Close();
                adminDashboard.Show();
            }
            else if(txtEmail.Text.ToUpper() == "CUSTOMER")
            {
                this.Hide();
                var customerDashboard = new Customer_Dashboard();
                customerDashboard.Closed += (s, args) => this.Close();
                customerDashboard.Show();
            }
            else
            {
                MessageBox.Show("No such user !");
            }
            
        }
    }
}
