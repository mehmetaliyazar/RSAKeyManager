using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAKeyManager
{
    public partial class FormExport : Form
    {
        public FormExport()
        {
            InitializeComponent();
        }

        MainForm mf = Application.OpenForms["MainForm"] as MainForm;
        private void btnExport_Click(object sender, EventArgs e)
        {
            string sendType = "";
            if (btnPublic.Checked)
            {
                sendType = "Public";
            }
            else if (btnPrivate.Checked)
            {
                sendType = "Private";
            }
            else if (!btnPublic.Checked && !btnPrivate.Checked)
            {
                MessageBox.Show(MainForm.languageManager.GetString("msgSelectType"), MainForm.languageManager.GetString("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);//msgBox
                return;
            }
            mf.Export(sendType);
            Close();
        }

        private void FormExport_Load(object sender, EventArgs e)
        {
            if (mf.KeyManager._KeyType == "Public") { btnPrivate.Enabled = false; }
            Text = MainForm.languageManager.GetString("formSelectKeyType");
            btnExport.Text = MainForm.languageManager.GetString("Export");
            btnPublic.Text = MainForm.languageManager.GetString("PublicKey");
            btnPrivate.Text = MainForm.languageManager.GetString("PrivateKey");
        }
    }
}
