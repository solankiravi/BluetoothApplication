using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BluetoothRijndael
{
    public partial class frmWaitingConnection : Form
    {
        public frmWaitingConnection()
        {
            InitializeComponent();
        }
        

        private void frmWaitingConnection_Load(object sender, EventArgs e)
        {
            label1.Text = "Waiting for a connection...";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
