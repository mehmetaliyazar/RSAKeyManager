
namespace RSAKeyManager
{
    partial class FormExport
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
            this.btnPublic = new System.Windows.Forms.RadioButton();
            this.btnPrivate = new System.Windows.Forms.RadioButton();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPublic
            // 
            this.btnPublic.Location = new System.Drawing.Point(12, 12);
            this.btnPublic.Name = "btnPublic";
            this.btnPublic.Size = new System.Drawing.Size(127, 21);
            this.btnPublic.TabIndex = 0;
            this.btnPublic.Text = "Public Key";
            this.btnPublic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPublic.UseVisualStyleBackColor = true;
            // 
            // btnPrivate
            // 
            this.btnPrivate.Location = new System.Drawing.Point(12, 39);
            this.btnPrivate.Name = "btnPrivate";
            this.btnPrivate.Size = new System.Drawing.Size(127, 21);
            this.btnPrivate.TabIndex = 1;
            this.btnPrivate.Text = "Private Key";
            this.btnPrivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrivate.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 66);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(127, 30);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 104);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrivate);
            this.Controls.Add(this.btnPublic);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a type to export";
            this.Load += new System.EventHandler(this.FormExport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton btnPublic;
        private System.Windows.Forms.RadioButton btnPrivate;
        private System.Windows.Forms.Button btnExport;
    }
}