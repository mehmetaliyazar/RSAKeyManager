
namespace RSAKeyManager
{
    partial class FormKey
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
            this.btn1024 = new System.Windows.Forms.RadioButton();
            this.btn2048 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn4096 = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.workerGenerate = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1024
            // 
            this.btn1024.AutoSize = true;
            this.btn1024.Location = new System.Drawing.Point(6, 24);
            this.btn1024.Name = "btn1024";
            this.btn1024.Size = new System.Drawing.Size(54, 21);
            this.btn1024.TabIndex = 0;
            this.btn1024.TabStop = true;
            this.btn1024.Text = "1024";
            this.btn1024.UseVisualStyleBackColor = true;
            this.btn1024.CheckedChanged += new System.EventHandler(this.btnSize_CheckedChanged);
            // 
            // btn2048
            // 
            this.btn2048.AutoSize = true;
            this.btn2048.Location = new System.Drawing.Point(6, 51);
            this.btn2048.Name = "btn2048";
            this.btn2048.Size = new System.Drawing.Size(54, 21);
            this.btn2048.TabIndex = 1;
            this.btn2048.TabStop = true;
            this.btn2048.Text = "2048";
            this.btn2048.UseVisualStyleBackColor = true;
            this.btn2048.CheckedChanged += new System.EventHandler(this.btnSize_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn4096);
            this.groupBox1.Controls.Add(this.btn1024);
            this.groupBox1.Controls.Add(this.btn2048);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Size";
            // 
            // btn4096
            // 
            this.btn4096.AutoSize = true;
            this.btn4096.Location = new System.Drawing.Point(6, 78);
            this.btn4096.Name = "btn4096";
            this.btn4096.Size = new System.Drawing.Size(154, 21);
            this.btn4096.TabIndex = 2;
            this.btn4096.TabStop = true;
            this.btn4096.Text = "4096 (Recommended)";
            this.btn4096.UseVisualStyleBackColor = true;
            this.btn4096.CheckedChanged += new System.EventHandler(this.btnSize_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 125);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(163, 25);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // workerGenerate
            // 
            this.workerGenerate.WorkerReportsProgress = true;
            this.workerGenerate.WorkerSupportsCancellation = true;
            this.workerGenerate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerGenerate_DoWork);
            this.workerGenerate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerGenerate_RunWorkerCompleted);
            // 
            // FormKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 158);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Key Size";
            this.Load += new System.EventHandler(this.FormKey_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton btn1024;
        private System.Windows.Forms.RadioButton btn2048;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btn4096;
        private System.Windows.Forms.Button btnGenerate;
        private System.ComponentModel.BackgroundWorker workerGenerate;
    }
}