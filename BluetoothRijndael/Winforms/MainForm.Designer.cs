namespace BluetoothRijndael
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
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
            this.HeadermenuStrip = new System.Windows.Forms.MenuStrip();
            this.bluetoothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeadermenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadermenuStrip
            // 
            this.HeadermenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bluetoothToolStripMenuItem,
            this.encryptionToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.HeadermenuStrip.Location = new System.Drawing.Point(0, 0);
            this.HeadermenuStrip.Name = "HeadermenuStrip";
            this.HeadermenuStrip.Size = new System.Drawing.Size(588, 24);
            this.HeadermenuStrip.TabIndex = 0;
            this.HeadermenuStrip.Text = "menuStrip1";
            // 
            // bluetoothToolStripMenuItem
            // 
            this.bluetoothToolStripMenuItem.Name = "bluetoothToolStripMenuItem";
            this.bluetoothToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.bluetoothToolStripMenuItem.Text = "Bluetooth";
            this.bluetoothToolStripMenuItem.Click += new System.EventHandler(this.bluetoothToolStripMenuItem_Click);
            // 
            // encryptionToolStripMenuItem
            // 
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            this.encryptionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.encryptionToolStripMenuItem.Text = "Encryption";
            this.encryptionToolStripMenuItem.Click += new System.EventHandler(this.encryptionToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 292);
            this.Controls.Add(this.HeadermenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.HeadermenuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HeadermenuStrip.ResumeLayout(false);
            this.HeadermenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip HeadermenuStrip;
        private System.Windows.Forms.ToolStripMenuItem bluetoothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}