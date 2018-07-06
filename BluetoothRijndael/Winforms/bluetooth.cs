using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using InTheHand.Net.Bluetooth;
using InTheHand.Net;
using InTheHand.Net.Sockets;

namespace BluetoothRijndael
{
    public partial class bluetooth : Form
    {
        InTheHand.Net.Sockets.BluetoothClient bluetoothClient;
     
        public bluetooth()
        {
            InitializeComponent();
        }

        private void btnDeviceDiscovery_Click(object sender, EventArgs e)
        {
            if (!BluetoothRadio.IsSupported)
            {
                MessageBox.Show("Adapter not found");
            }
            else
            {
                InTheHand.Net.Sockets.BluetoothClient bc = new InTheHand.Net.Sockets.BluetoothClient();

                InTheHand.Net.Sockets.BluetoothDeviceInfo[] array = bc.DiscoverDevices();
                for (int i = 0; i < array.Length; i++)
                {
                    this.address_array[i] = array[i].DeviceAddress;
                    this.lsDevices.Items.Add(array[i].DeviceName);
                }
            }
        }

        private void btnGetMacAddress_Click(object sender, EventArgs e)
        {
            if (this.lsDevices.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a device.");
                return;
            }
            int index = this.lsDevices.SelectedIndex;
            string mac = this.address_array[index].ToString();
            string nap = this.address_array[index].Nap.ToString();
            string sap = this.address_array[index].Sap.ToString();

            lblMac.Text = "MAC : " + mac.ToString();
            lblNap.Text = "NAP :" + nap.ToString();
            lblSap.Text = "SAP :" + sap.ToString();
            

        }

        private void btnSendFiles_Click(object sender, EventArgs e)
        {
            try
            {
                var sbdd = new InTheHand.Windows.Forms.SelectBluetoothDeviceDialog();
                sbdd.ShowAuthenticated = true;
                sbdd.ShowRemembered = true;
                sbdd.ShowUnknown = true;

                InTheHand.Net.Sockets.BluetoothDeviceInfo deviceInfo = null;

                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (sbdd.ShowDialog() == DialogResult.OK)
                {
                    deviceInfo = sbdd.SelectedDevice;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var file = openFileDialog.FileName;
                        var uri = new Uri("obex://" + deviceInfo.DeviceAddress + "/" + file);
                        var request = new InTheHand.Net.ObexWebRequest(uri);
                        request.ReadFile(file);
                        var response = (InTheHand.Net.ObexWebResponse)request.GetResponse();
                        MessageBox.Show(response.StatusCode.ToString());
                        response.Close();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReceiveFiles_Click_Click(object sender, EventArgs e)
        {
            try
            {
                InTheHand.Net.ObexListener listener = new InTheHand.Net.ObexListener();
                listener.Start();

                InTheHand.Net.ObexListenerContext context = null;
                BluetoothRijndael.frmWaitingConnection waitingConnectionForm = new BluetoothRijndael.frmWaitingConnection();
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    context = listener.GetContext();
                    if (waitingConnectionForm.Visible)
                        waitingConnectionForm.Invoke(new MethodInvoker(delegate { waitingConnectionForm.Close(); }));
                }).Start();

                if (waitingConnectionForm.ShowDialog() == DialogResult.Cancel)
                {
                    if (listener.IsListening)
                        listener.Stop();
                }

                if (context != null)
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileLocation = folderBrowserDialog.SelectedPath + context.Request.RawUrl;
                        context.Request.WriteFile(fileLocation);
                        MessageBox.Show("File saved at: \n" + fileLocation);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bluetooth_Load(object sender, EventArgs e)
        {
            try
            {
                if (BluetoothRadio.IsSupported)
                {
                    bluetoothClient = new InTheHand.Net.Sockets.BluetoothClient();

                    if (BluetoothRadio.PrimaryRadio.Mode == RadioMode.PowerOff)
                        BluetoothRadio.PrimaryRadio.Mode = RadioMode.Connectable;
                }
                else
                {
                    MessageBox.Show("Adaptar is not detected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bluetoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // bluetooth blue = new bluetooth();
           
        }

    }
}


