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
    public partial class GeneralWelcomeForm : Form
    {
        public GeneralWelcomeForm()
        {
            InitializeComponent();
        }

        

        private void Swipebtn_Click(object sender, EventArgs e)
        {
            TransactParentForm f2=new TransactParentForm();
            this.Hide();
            f2.ShowDialog();
            this.Show();
            
            

        }
    }
}
