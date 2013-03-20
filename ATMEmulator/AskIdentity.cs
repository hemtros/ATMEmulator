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
    public partial class AskIdentity : Form
    {

        public AskIdentity()
        {
            InitializeComponent();
        }

        private void AskIdentity_Load(object sender, EventArgs e)
        {

            this.ControlBox = false;
            this.WindowState=FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pic = Convert.ToInt32(PICTextBox.Text);
            Customer cust = new Customer();
            cust.Pic = pic;



            CustDetTableAccess cdta=new CustDetTableAccess();
            cdta.Sqlcon();
            string retcustname=cdta.QueryExe(cust);
            
            
            
            EnterPincode ep=new EnterPincode();
            ep.Customername = retcustname;
            ep.Show();
            this.Dispose();
            





        }
    }
}
