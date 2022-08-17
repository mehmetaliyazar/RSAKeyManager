using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RSAKeyManager
{
    public partial class FormKey : Form
    {
        public FormKey(KeyClass keyclass)
        {
            InitializeComponent();
            _keyClass = keyclass;
        }

        KeyClass _keyClass = null;
        int keySize = 0;
        ProgressBar pbar = null;

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (keySize == 0)
            {
                MessageBox.Show(MainForm.languageManager.GetString("msgSelectKeySize"), MainForm.languageManager.GetString("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);//msgBox
                return;
            }
            btnGenerate.Enabled = false;
            groupBox1.Enabled = false;
            pbar = new ProgressBar();
            pbar.Size = btnGenerate.Size;
            pbar.Maximum = 100;
            pbar.Style = ProgressBarStyle.Marquee;
            pbar.Location = btnGenerate.Location;
            Controls.Add(pbar);
            pbar.BringToFront();
            workerGenerate.RunWorkerAsync();
        }

        private void btnSize_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton me = sender as RadioButton;
            switch (me.Name)
            {
                case "btn1024": keySize = 1024; break;
                case "btn2048": keySize = 2048; break;
                case "btn4096": keySize = 4096; break;
            }
        }

        private void workerGenerate_DoWork(object sender, DoWorkEventArgs e)
        {
            _keyClass.GenerateKey(keySize);
        }

        private void workerGenerate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_keyClass.RSAKey != null)
            {
                Controls.Remove(pbar);
                MessageBox.Show(MainForm.languageManager.GetString("msgGenerated"), MainForm.languageManager.GetString("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);//msgBox
                MainForm mf = Application.OpenForms["MainForm"] as MainForm;
                mf.CheckForKey();
                Close();
            }
            else
            {
                MessageBox.Show(MainForm.languageManager.GetString("msgGenerateFailed"), MainForm.languageManager.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);//msgBox
            }
        }

        private void FormKey_Load(object sender, EventArgs e)
        {
            Text = MainForm.languageManager.GetString("formSelectKeySize");
            btn4096.Text = "4096 (" + MainForm.languageManager.GetString("Recommended") + ")";
            btnGenerate.Text = MainForm.languageManager.GetString("Generate");
        }
    }
}
