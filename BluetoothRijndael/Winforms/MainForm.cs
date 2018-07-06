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
    public partial class MainForm : Form
    {
        bluetooth bluetooth = null;
        RijndaelFrm rijndael = null;
        public MainForm()
        {
            InitializeComponent();
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
            bluetooth bt = new bluetooth();
            bt.Show();
            bt.MdiParent = this;
        }

        private void bluetoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bluetooth == null || bluetooth.Text == "")
            {
                bluetooth = new bluetooth();
                bluetooth.MdiParent = this;
                bluetooth.Dock = DockStyle.Fill;
             
                bluetooth.Show();
            }
            else if (CheckOpened(rijndael.Text))
            {
                bluetooth.WindowState = FormWindowState.Normal;
                bluetooth.Dock = DockStyle.Fill;
             
                bluetooth.Show();
                bluetooth.Focus();
            }     


        }

        private void encryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (rijndael == null || rijndael.Text == "")
            {
                rijndael = new RijndaelFrm();
                rijndael.MdiParent = this;
                rijndael.Dock = DockStyle.Fill;
              
                rijndael.Show();
            }
            else if (CheckOpened(rijndael.Text))
            {
                rijndael.WindowState = FormWindowState.Normal;
                rijndael.Dock = DockStyle.Fill;
                rijndael.Show();
           
                rijndael.Focus();
            }     
        }

        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
