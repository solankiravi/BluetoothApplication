using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BluetoothRijndael
{
    public partial class RijndaelFrm : Form
    {
        public const int MAX_BLOCK_LENGTH = 16;
        public const int MAX_KEY_LENGTH = 16;

        private enum ErrorID
        {
            NullFilePath = 0,
            NUllFileSave,
            NullPWD,
            OtherError,
            Success,
        };

        private string[] ErrorString = new string[]{
            "No File be Selected",
            "No File be Saved",
            "No Password input",
            "Other Error",
            "OK"};

        private enum Direction
        {
            Encrypt = 0,
            Decrypt,
        };

        private KeySize ekeySize;
        private BlockSize eblockSize;
        private Direction eDirEnDe;

        public RijndaelFrm()
        {
            InitializeComponent();
        }

        private void RijndaelFrm_Load(object sender, EventArgs e) //form load
        {
            ekeySize = KeySize.Bits128;
            eblockSize = BlockSize.Bits128;
            eDirEnDe = Direction.Encrypt;
        }

        private void EnOption_CheckedChanged(object sender, EventArgs e)
        {
            EnDeCode.Text = this.EnOption.Text;
            TxtFilePath.Text = "";
            TxtFileSave.Text = "";
            eDirEnDe = Direction.Encrypt;
        }

        private void EnDeCode_Click(object sender, EventArgs e)
        {
            ErrorID errorID = CheckParam();
            if (ErrorID.Success != errorID)
            {
                string errorString = GetErrorString(errorID);
                MessageBox.Show(errorString, "Rijndael");
                return;
            }
            //get param
            string cOpenFile = TxtFilePath.Text;
            string cSaveFile = TxtFileSave.Text;
            string cPassword = txtPwd.Text;
            //check param successfully
            if (Direction.Encrypt == eDirEnDe)
            {
                Boolean bValue = Encrypt(cOpenFile, cSaveFile, cPassword);
                if (false == bValue)
                {
                    MessageBox.Show("Encrypt Fail", "Rijndael");
                    return;
                }

            }
            else
            {
                Boolean bValue = Decrypt(cOpenFile, cSaveFile, cPassword);
                if (false == bValue)
                {
                    MessageBox.Show("Decrypt Fail", "Rijndael");
                    return;
                }
            }
        }

        private void DeOption_CheckedChanged(object sender, EventArgs e)
        {
            EnDeCode.Text = this.DeOption.Text;
            TxtFilePath.Text = "";
            TxtFileSave.Text = "";
            eDirEnDe = Direction.Decrypt;
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Rijndael";
            if (eDirEnDe == Direction.Encrypt)
            {
                openFileDialog.Filter = "All File|*.*";
                if (DialogResult.OK == openFileDialog.ShowDialog())
                {
                    string fName = openFileDialog.FileName;
                    TxtFilePath.Text = fName;
                    TxtFileSave.Text = fName + ".aes";
                }
            }
            else
            {
                openFileDialog.Filter = "AES File|*.aes";
                if (DialogResult.OK == openFileDialog.ShowDialog())
                {
                    string fName = openFileDialog.FileName;
                    TxtFilePath.Text = fName;
                    int iLastIndex = fName.LastIndexOf(".");
                    string cOrigalName = fName.Substring(0, iLastIndex);
                    TxtFileSave.Text = cOrigalName;
                }
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
         
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Rijndael";

            if (eDirEnDe == Direction.Encrypt)
            {
                saveFileDialog.Filter = "AES File|*.aes";
                DialogResult dialogResult = saveFileDialog.ShowDialog();
                
                string fName = saveFileDialog.FileName;
                if (("" != fName) && (dialogResult == DialogResult.OK))
                {
                    TxtFileSave.Text = fName;
                }
            }
            else
            {
                saveFileDialog.Filter = "All File|*.*";
                DialogResult dialogResult = saveFileDialog.ShowDialog();
               
                string fName = saveFileDialog.FileName;
                if (("" != fName) && (dialogResult == DialogResult.OK))
                {
                    TxtFileSave.Text = fName;
                }
            }
        }

        private ErrorID CheckParam()
        {
            if ("" == TxtFilePath.Text)
            {
                return ErrorID.NullFilePath;
            }

            if ("" == TxtFileSave.Text)
            {
                return ErrorID.NUllFileSave;
            }

            if ("" == txtPwd.Text)
            {
                return ErrorID.NullPWD;
            }

            return ErrorID.Success;
        }

        private string GetErrorString(ErrorID errorID)
        {
            int iIndex = (int)(errorID);

            return ErrorString[iIndex];
        }

        private Boolean Encrypt(string cOpenFile, string cSaveFile, string cPassword)
        {
           
            if (("" == cOpenFile) ||
                ("" == cSaveFile) ||
                ("" == cPassword))
            {
                return false;
            }

            if (false == File.Exists(cOpenFile))
            {
                return false;
            }

            while (true == File.Exists(cSaveFile))
            {
                cSaveFile = Rename(cSaveFile);
            }

            byte[] plainText = new byte[MAX_BLOCK_LENGTH];
            byte[] cipherText = new byte[MAX_BLOCK_LENGTH];
            byte[] bzkey = new byte[MAX_KEY_LENGTH];

           
            bzkey = Encoding.Unicode.GetBytes(cPassword);

            FileStream fileStream = new FileStream(cOpenFile, FileMode.Open);
            fileStream.Seek(0, SeekOrigin.Begin);

            FileStream saveStream = new FileStream(cSaveFile, FileMode.Append);

            long lFileLength = fileStream.Length;
            
            long lPostion = fileStream.Position;

           
            while (lPostion < lFileLength)
            {
                
                Initialize(plainText, MAX_BLOCK_LENGTH);

                long lHasRead = fileStream.Read(plainText, 0, MAX_BLOCK_LENGTH);
                if (0 >= lHasRead)
                {
                    break;
                }
                
                lPostion = fileStream.Position;

               
                Aes aes = new Aes(ekeySize, bzkey, eblockSize);

                Initialize(cipherText, MAX_BLOCK_LENGTH);

                aes.Cipher(plainText, cipherText);
                saveStream.Write(cipherText, 0, MAX_BLOCK_LENGTH);
            }

            saveStream.Close();
            fileStream.Close();
            return true;
        }

        private Boolean Decrypt(string cOpenFile, string cSaveFile, string cPassword)
        {
            
            if (("" == cOpenFile) ||
                ("" == cSaveFile) ||
                ("" == cPassword))
            {
                return false;
            }

            if (0 > cOpenFile.LastIndexOf(".aes"))
            {
                return false;
            }

            if (false == File.Exists(cOpenFile))
            {
                return false;
            }

            while (true == File.Exists(cSaveFile))
            {
                cSaveFile = Rename(cSaveFile);
            }

            byte[] plainText = new byte[MAX_BLOCK_LENGTH];
            byte[] cipherText = new byte[MAX_BLOCK_LENGTH];
            byte[] bzkey = new byte[MAX_KEY_LENGTH];

            bzkey = Encoding.Unicode.GetBytes(cPassword);

            FileStream fileStream = new FileStream(cOpenFile, FileMode.Open);
            fileStream.Seek(0, SeekOrigin.Begin);
 
            FileStream saveStream = new FileStream(cSaveFile, FileMode.Append);

            
            long lFileLength = fileStream.Length;
            
            long lPostion = fileStream.Position;

           
            while (lPostion < lFileLength)
            {
                
                Initialize(plainText, MAX_BLOCK_LENGTH);

                long lHasRead = fileStream.Read(plainText, 0, MAX_BLOCK_LENGTH);
                if (0 >= lHasRead)
                {
                    break;
                }
                
                lPostion = fileStream.Position;

              
                Aes aes = new Aes(ekeySize, bzkey, eblockSize);

                Initialize(cipherText, MAX_BLOCK_LENGTH);
              
                aes.InvCipher(plainText, cipherText);
                saveStream.Write(cipherText, 0, MAX_BLOCK_LENGTH);
            }

            saveStream.Close();
            fileStream.Close();

            return true;
        }

        private void Initialize(byte[] pByte, int iLength)
        {
            int iIndex = 0;
            for (iIndex = 0; iIndex < iLength; iIndex++)
            {
                pByte[iIndex] = 0;
            }
        }

        private string Rename(string cName)
        {
            string cFileName = cName;
            string cExtentName = "";
            int iIndex = cName.IndexOf(".");
            if (iIndex > 0)
            {
                cFileName = cName.Substring(0, iIndex);
                cExtentName = cName.Substring(iIndex);
            }
            cFileName += "aes";
            cFileName += cExtentName;
            return cFileName;
        }
    }
}