using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMEmulator
{
    public partial class EnterPincode : Form
    {
        private string customername;
        public EnterPincode()
        {
            InitializeComponent();
        }

        public EnterPincode(Customer cust)
        {
            customername = cust.Name;
        }
         
        private void EnterPincode_Load(object sender, EventArgs e)
        {
            Customer c=new Customer();
            WelcomeTextBox.Text = "Welcome" + customername;
        }
    }
}
