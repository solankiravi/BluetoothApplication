using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using System.Threading;

namespace BluetoothRijndael
{
    partial class bluetooth
    {
        /// <summary>
        /// Required designer variable.
        InTheHand.Net.BluetoothAddress[] address_array = new BluetoothAddress[1000];
       // private Thread thrSend;
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeviceDescovery = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSap = new System.Windows.Forms.Label();
            this.lblNap = new System.Windows.Forms.Label();
            this.lblMac = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSendFiles = new System.Windows.Forms.Button();
            this.btnGetMacAddress = new System.Windows.Forms.Button();
            this.lsDevices = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRecieveFiles = new System.Windows.Forms.Button();
            this.groupBoxDeviceStatus = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFoundDevices = new System.Windows.Forms.Label();
            this.groupBoxDeviceStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeviceDescovery
            // 
            this.btnDeviceDescovery.Location = new System.Drawing.Point(237, 105);
            this.btnDeviceDescovery.Name = "btnDeviceDescovery";
            this.btnDeviceDescovery.Size = new System.Drawing.Size(105, 23);
            this.btnDeviceDescovery.TabIndex = 30;
            this.btnDeviceDescovery.Text = "Device Discovery";
            this.btnDeviceDescovery.UseVisualStyleBackColor = true;
            this.btnDeviceDescovery.Click += new System.EventHandler(this.btnDeviceDiscovery_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(146, 35);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(291, 25);
            this.lblHeading.TabIndex = 28;
            this.lblHeading.Text = "Transfer files on Bluetooth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 4;
            // 
            // lblSap
            // 
            this.lblSap.AutoSize = true;
            this.lblSap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSap.Location = new System.Drawing.Point(6, 114);
            this.lblSap.Name = "lblSap";
            this.lblSap.Size = new System.Drawing.Size(28, 13);
            this.lblSap.TabIndex = 2;
            this.lblSap.Text = "SAP";
            // 
            // lblNap
            // 
            this.lblNap.AutoSize = true;
            this.lblNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNap.Location = new System.Drawing.Point(6, 76);
            this.lblNap.Name = "lblNap";
            this.lblNap.Size = new System.Drawing.Size(29, 13);
            this.lblNap.TabIndex = 1;
            this.lblNap.Text = "NAP";
            // 
            // lblMac
            // 
            this.lblMac.AutoSize = true;
            this.lblMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMac.Location = new System.Drawing.Point(6, 37);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(30, 13);
            this.lblMac.TabIndex = 0;
            this.lblMac.Text = "MAC";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(440, 241);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 23);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 6;
            // 
            // btnSendFiles
            // 
            this.btnSendFiles.Location = new System.Drawing.Point(237, 181);
            this.btnSendFiles.Name = "btnSendFiles";
            this.btnSendFiles.Size = new System.Drawing.Size(105, 23);
            this.btnSendFiles.TabIndex = 32;
            this.btnSendFiles.Text = "Send files";
            this.btnSendFiles.UseVisualStyleBackColor = true;
            this.btnSendFiles.Click += new System.EventHandler(this.btnSendFiles_Click);
            // 
            // btnGetMacAddress
            // 
            this.btnGetMacAddress.Location = new System.Drawing.Point(237, 141);
            this.btnGetMacAddress.Name = "btnGetMacAddress";
            this.btnGetMacAddress.Size = new System.Drawing.Size(105, 23);
            this.btnGetMacAddress.TabIndex = 31;
            this.btnGetMacAddress.Text = "Get MAC Address";
            this.btnGetMacAddress.UseVisualStyleBackColor = true;
            this.btnGetMacAddress.Click += new System.EventHandler(this.btnGetMacAddress_Click);
            // 
            // lsDevices
            // 
            this.lsDevices.FormattingEnabled = true;
            this.lsDevices.Location = new System.Drawing.Point(51, 105);
            this.lsDevices.Name = "lsDevices";
            this.lsDevices.Size = new System.Drawing.Size(151, 147);
            this.lsDevices.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 7;
            // 
            // btnRecieveFiles
            // 
            this.btnRecieveFiles.Location = new System.Drawing.Point(237, 224);
            this.btnRecieveFiles.Name = "btnRecieveFiles";
            this.btnRecieveFiles.Size = new System.Drawing.Size(105, 23);
            this.btnRecieveFiles.TabIndex = 36;
            this.btnRecieveFiles.Text = "Receive files";
            this.btnRecieveFiles.UseVisualStyleBackColor = true;
            // 
            // groupBoxDeviceStatus
            // 
            this.groupBoxDeviceStatus.Controls.Add(this.label13);
            this.groupBoxDeviceStatus.Controls.Add(this.label10);
            this.groupBoxDeviceStatus.Controls.Add(this.label9);
            this.groupBoxDeviceStatus.Controls.Add(this.label8);
            this.groupBoxDeviceStatus.Controls.Add(this.label7);
            this.groupBoxDeviceStatus.Controls.Add(this.lblSap);
            this.groupBoxDeviceStatus.Controls.Add(this.lblNap);
            this.groupBoxDeviceStatus.Controls.Add(this.lblMac);
            this.groupBoxDeviceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDeviceStatus.Location = new System.Drawing.Point(348, 88);
            this.groupBoxDeviceStatus.Name = "groupBoxDeviceStatus";
            this.groupBoxDeviceStatus.Size = new System.Drawing.Size(221, 147);
            this.groupBoxDeviceStatus.TabIndex = 35;
            this.groupBoxDeviceStatus.TabStop = false;
            this.groupBoxDeviceStatus.Text = "Device status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 5;
            // 
            // lblFoundDevices
            // 
            this.lblFoundDevices.AutoSize = true;
            this.lblFoundDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundDevices.Location = new System.Drawing.Point(51, 78);
            this.lblFoundDevices.Name = "lblFoundDevices";
            this.lblFoundDevices.Size = new System.Drawing.Size(151, 24);
            this.lblFoundDevices.TabIndex = 29;
            this.lblFoundDevices.Text = "Found Devices";
            // 
            // bluetooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(621, 299);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeviceDescovery);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSendFiles);
            this.Controls.Add(this.btnGetMacAddress);
            this.Controls.Add(this.lsDevices);
            this.Controls.Add(this.btnRecieveFiles);
            this.Controls.Add(this.groupBoxDeviceStatus);
            this.Controls.Add(this.lblFoundDevices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bluetooth";
            this.Text = "Bluetooth";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.bluetooth_Load);
            this.groupBoxDeviceStatus.ResumeLayout(false);
            this.groupBoxDeviceStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeviceDescovery;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSap;
        private System.Windows.Forms.Label lblNap;
        private System.Windows.Forms.Label lblMac;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSendFiles;
        private System.Windows.Forms.Button btnGetMacAddress;
        private System.Windows.Forms.ListBox lsDevices;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRecieveFiles;
        private System.Windows.Forms.GroupBox groupBoxDeviceStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFoundDevices;



    }
}

