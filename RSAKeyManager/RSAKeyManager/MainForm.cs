using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Resources;
using System.Globalization;
using System.Reflection;

namespace RSAKeyManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public KeyClass KeyManager = new KeyClass();
        int _keySize = 0;
        string _type = string.Empty;

        public static ResourceManager languageManager;

        private void MainForm_Load(object sender, EventArgs e)
        {
            CultureInfo lang = CultureInfo.CurrentUICulture;
            if (lang.ThreeLetterISOLanguageName == "eng") { languageManager = new ResourceManager("RSAKeyManager.Languages.language_en", Assembly.GetExecutingAssembly()); }
            else if (lang.ThreeLetterISOLanguageName == "tur") { languageManager = new ResourceManager("RSAKeyManager.Languages.language_tr", Assembly.GetExecutingAssembly()); }

            Text = languageManager.GetString("formMain");
            btnGenerate.Text = languageManager.GetString("GenerateKey");
            btnImport.Text = languageManager.GetString("ImportKey");
            groupBox1.Text = languageManager.GetString("KeyInformation");
            lblKey.Text = languageManager.GetString("Key") + ": -";
            lblKeySize.Text = languageManager.GetString("KeySize") + ": -";
            btnExport.Text = languageManager.GetString("ExportKey");
            btnTest.Text = languageManager.GetString("Test");
        }

        public void ClearKey()
        {
            KeyManager = null;
            KeyManager = new KeyClass();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            FormKey fk = new FormKey(KeyManager);
            fk.ShowDialog();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Takes three arguments
            //First argument is for process. Export or Import.
            //Second argument for type. Public or Private.
            //Third argument is file path for key to export or import.
            string[] arguments = e.Argument as string[];
            e.Result = arguments;
            if (arguments[0] == "Export")
            {
                XmlDocument xmlDoc = new XmlDocument();
                if (arguments[1] == "Public")
                {
                    xmlDoc.LoadXml(KeyManager.RSAKey.ToXmlString(false));
                }
                else if (arguments[1] == "Private")
                {
                    xmlDoc.LoadXml(KeyManager.RSAKey.ToXmlString(true));
                }
                xmlDoc.Save(arguments[2]);
            }
            else if (arguments[0] == "Import")
            {
                ClearKey();
                KeyManager.ImportKey(arguments[2]);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML File | *.xml";
            ofd.DefaultExt = "xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] arguments = { "Import", "", ofd.FileName };
                worker.RunWorkerAsync(arguments);
            }
        }

        public void CheckForKey()
        {
            if (KeyManager.RSAKey == null)
            {
                MessageBox.Show("key yok");
                lblKey.Text = languageManager.GetString("Key") + ": " + languageManager.GetString("NoKey");
                lblKeySize.Text = languageManager.GetString("KeySize") + ": -";
                btnExport.Enabled = false;
                btnTest.Enabled = false;
            }
            else
            {
                lblKey.Text = languageManager.GetString("Key") + ": " + languageManager.GetString(KeyManager._KeyType);
                lblKeySize.Text = languageManager.GetString("KeySize") + ": " + KeyManager._KeySize.ToString();
                btnExport.Enabled = true;
                btnTest.Enabled = true;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FormExport fe = new FormExport();
            fe.ShowDialog();
        }

        public void Export(string type)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML File | *.xml";
            sfd.DefaultExt = "xml";
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string[] _arguments = { "Export", type, sfd.FileName };
                worker.RunWorkerAsync(_arguments);
            }
            else
            {
                //MessageBox.Show("Export STOPPED!");//msgBox
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            FormTest ft = new FormTest();
            ft.ShowDialog();
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string[] results = e.Result as string[];
            if (results[1] == "Public")
            {
                MessageBox.Show(languageManager.GetString("msgPublicKeyExported"), languageManager.GetString("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);//msgBox
            }
            else if (results[1] == "Private")
            {
                MessageBox.Show(languageManager.GetString("msgPrivateKeyExported"), languageManager.GetString("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);//msgBox
            }
            if (results[0] == "Import")
            {
                lblKey.Text = KeyManager._KeyType;
                CheckForKey();
            }
        }
    }
}
