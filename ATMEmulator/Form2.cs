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
    public partial class TransactParentForm : Form
    {
        public TransactParentForm()
        {
            InitializeComponent();
        }

        private void TransactParentForm_Load(object sender, EventArgs e)
        {
            AskIdentity ai=new AskIdentity();
            ai.MdiParent = this;
            
            ai.Show();
        }
    }
}
