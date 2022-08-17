using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAKeyManager
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        KeyClass keyManager;

        private void FormTest_Load(object sender, EventArgs e)
        {
            Text = MainForm.languageManager.GetString("formTest");
            label1.Text = MainForm.languageManager.GetString("TextToEncrypt");
            label2.Text = MainForm.languageManager.GetString("EncryptedText");
            label3.Text = MainForm.languageManager.GetString("TextToDecrypt");
            label4.Text = MainForm.languageManager.GetString("DecryptedText");
            MainForm mf = Application.OpenForms["MainForm"] as MainForm;
            keyManager = mf.KeyManager;
        }

        private void txtEnc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtEncrypted.Text = keyManager.EncryptData(txtEnc.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MainForm.languageManager.GetString("msgEncryptError"), MainForm.languageManager.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);//msgBox
                txtEnc.Clear();
                txtEncrypted.Clear();
            }
        }

        private void txtDec_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDecrypted.Text = keyManager.DecryptData(txtDec.Text);
            }
            catch (FormatException ex)//base64string değilse
            {
                MessageBox.Show(MainForm.languageManager.GetString("msgDecryptError"), MainForm.languageManager.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error); //msgBox
                txtDec.Clear();
                txtDecrypted.Clear();
            }
            catch (DecoderFallbackException ex)
            {
                MessageBox.Show(MainForm.languageManager.GetString("msgDecryptError2"), MainForm.languageManager.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error); //msgBox
                txtDec.Clear();
                txtDecrypted.Clear();
            }
            catch (CryptographicException ex)//public key ile decrypt etmeye çalışınca
            {
                MessageBox.Show(MainForm.languageManager.GetString("msgDecryptCryptographicError"), MainForm.languageManager.GetString("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);//msgBox
                txtDec.Clear();
                txtDecrypted.Clear();
            }
        }
    }
}
