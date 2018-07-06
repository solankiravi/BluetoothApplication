namespace BluetoothRijndael
{
    partial class RijndaelFrm
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
            this.WJFrame = new System.Windows.Forms.GroupBox();
            this.XXFrame = new System.Windows.Forms.GroupBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnDeCode = new System.Windows.Forms.Button();
            this.DeOption = new System.Windows.Forms.RadioButton();
            this.EnOption = new System.Windows.Forms.RadioButton();
            this.Save = new System.Windows.Forms.Button();
            this.TxtFileSave = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.TxtFilePath = new System.Windows.Forms.TextBox();
            this.WJFrame.SuspendLayout();
            this.XXFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // WJFrame
            // 
            this.WJFrame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WJFrame.Controls.Add(this.XXFrame);
            this.WJFrame.Controls.Add(this.Save);
            this.WJFrame.Controls.Add(this.TxtFileSave);
            this.WJFrame.Controls.Add(this.Browse);
            this.WJFrame.Controls.Add(this.TxtFilePath);
            this.WJFrame.Location = new System.Drawing.Point(3, 3);
            this.WJFrame.Margin = new System.Windows.Forms.Padding(4);
            this.WJFrame.Name = "WJFrame";
            this.WJFrame.Padding = new System.Windows.Forms.Padding(4);
            this.WJFrame.Size = new System.Drawing.Size(688, 196);
            this.WJFrame.TabIndex = 0;
            this.WJFrame.TabStop = false;
            this.WJFrame.Text = "File Encryption and Decryption";
            // 
            // XXFrame
            // 
            this.XXFrame.Controls.Add(this.txtPwd);
            this.XXFrame.Controls.Add(this.label1);
            this.XXFrame.Controls.Add(this.EnDeCode);
            this.XXFrame.Controls.Add(this.DeOption);
            this.XXFrame.Controls.Add(this.EnOption);
            this.XXFrame.Location = new System.Drawing.Point(23, 126);
            this.XXFrame.Margin = new System.Windows.Forms.Padding(4);
            this.XXFrame.Name = "XXFrame";
            this.XXFrame.Padding = new System.Windows.Forms.Padding(4);
            this.XXFrame.Size = new System.Drawing.Size(640, 48);
            this.XXFrame.TabIndex = 4;
            this.XXFrame.TabStop = false;
            this.XXFrame.Text = "Option";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(255, 14);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd.MaxLength = 8;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(208, 25);
            this.txtPwd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(196, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "PWD";
            // 
            // EnDeCode
            // 
            this.EnDeCode.Location = new System.Drawing.Point(488, 12);
            this.EnDeCode.Margin = new System.Windows.Forms.Padding(4);
            this.EnDeCode.Name = "EnDeCode";
            this.EnDeCode.Size = new System.Drawing.Size(151, 34);
            this.EnDeCode.TabIndex = 2;
            this.EnDeCode.Text = "Encrypt";
            this.EnDeCode.UseVisualStyleBackColor = true;
            this.EnDeCode.Click += new System.EventHandler(this.EnDeCode_Click);
            // 
            // DeOption
            // 
            this.DeOption.AutoSize = true;
            this.DeOption.Location = new System.Drawing.Point(97, 18);
            this.DeOption.Margin = new System.Windows.Forms.Padding(4);
            this.DeOption.Name = "DeOption";
            this.DeOption.Size = new System.Drawing.Size(74, 21);
            this.DeOption.TabIndex = 1;
            this.DeOption.Text = "Decrypt";
            this.DeOption.UseVisualStyleBackColor = true;
            this.DeOption.CheckedChanged += new System.EventHandler(this.DeOption_CheckedChanged);
            // 
            // EnOption
            // 
            this.EnOption.AutoSize = true;
            this.EnOption.Checked = true;
            this.EnOption.Location = new System.Drawing.Point(12, 18);
            this.EnOption.Margin = new System.Windows.Forms.Padding(4);
            this.EnOption.Name = "EnOption";
            this.EnOption.Size = new System.Drawing.Size(72, 21);
            this.EnOption.TabIndex = 0;
            this.EnOption.TabStop = true;
            this.EnOption.Text = "Encrypt";
            this.EnOption.UseVisualStyleBackColor = true;
            this.EnOption.CheckedChanged += new System.EventHandler(this.EnOption_CheckedChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(509, 78);
            this.Save.Margin = new System.Windows.Forms.Padding(4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(155, 29);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // TxtFileSave
            // 
            this.TxtFileSave.Location = new System.Drawing.Point(23, 78);
            this.TxtFileSave.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFileSave.Name = "TxtFileSave";
            this.TxtFileSave.Size = new System.Drawing.Size(465, 25);
            this.TxtFileSave.TabIndex = 2;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(509, 29);
            this.Browse.Margin = new System.Windows.Forms.Padding(4);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(156, 29);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.Location = new System.Drawing.Point(23, 29);
            this.TxtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.Size = new System.Drawing.Size(467, 25);
            this.TxtFilePath.TabIndex = 0;
            // 
            // RijndaelFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 200);
            this.ControlBox = false;
            this.Controls.Add(this.WJFrame);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RijndaelFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rijndael";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RijndaelFrm_Load);
            this.WJFrame.ResumeLayout(false);
            this.WJFrame.PerformLayout();
            this.XXFrame.ResumeLayout(false);
            this.XXFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WJFrame;
        private System.Windows.Forms.TextBox TxtFilePath;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox TxtFileSave;
        private System.Windows.Forms.GroupBox XXFrame;
        private System.Windows.Forms.RadioButton DeOption;
        private System.Windows.Forms.RadioButton EnOption;
        private System.Windows.Forms.Button EnDeCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPwd;

    }
}

