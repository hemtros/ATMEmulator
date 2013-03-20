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
        public string Customername { get; set; }
        public EnterPincode()
        {
            InitializeComponent();
        }

       
         
        private void EnterPincode_Load(object sender, EventArgs e)
        {

            WelcomeLabel.Text = "Welcome " + this.Customername;
        }
    }
}
