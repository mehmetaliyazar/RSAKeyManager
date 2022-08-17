
namespace RSAKeyManager
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKeySize = new System.Windows.Forms.Label();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(187, 35);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Key";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 53);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(187, 35);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import Key";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(6, 84);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(175, 25);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export Key";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblKey
            // 
            this.lblKey.Location = new System.Drawing.Point(6, 27);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(175, 20);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "Key: THERE IS NO KEY";
            this.lblKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTest
            // 
            this.btnTest.Enabled = false;
            this.btnTest.Location = new System.Drawing.Point(6, 115);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(175, 25);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.lblKeySize);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.lblKey);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 149);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Information";
            // 
            // lblKeySize
            // 
            this.lblKeySize.Location = new System.Drawing.Point(6, 54);
            this.lblKeySize.Name = "lblKeySize";
            this.lblKeySize.Size = new System.Drawing.Size(175, 20);
            this.lblKeySize.TabIndex = 5;
            this.lblKeySize.Text = "Key Size: -";
            this.lblKeySize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 250);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnGenerate);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Key Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKeySize;
        private System.ComponentModel.BackgroundWorker worker;
    }
}

