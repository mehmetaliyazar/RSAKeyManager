
namespace RSAKeyManager
{
    partial class FormTest
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
            this.txtEnc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncrypted = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDecrypted = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDec = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtEnc
            // 
            this.txtEnc.Location = new System.Drawing.Point(12, 28);
            this.txtEnc.Name = "txtEnc";
            this.txtEnc.Size = new System.Drawing.Size(203, 74);
            this.txtEnc.TabIndex = 0;
            this.txtEnc.Text = "";
            this.txtEnc.TextChanged += new System.EventHandler(this.txtEnc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text to Encrypt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "--->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted Text";
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(259, 28);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.ReadOnly = true;
            this.txtEncrypted.Size = new System.Drawing.Size(203, 74);
            this.txtEncrypted.TabIndex = 3;
            this.txtEncrypted.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Decrypted Text";
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(259, 154);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.ReadOnly = true;
            this.txtDecrypted.Size = new System.Drawing.Size(203, 74);
            this.txtDecrypted.TabIndex = 8;
            this.txtDecrypted.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "--->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Text to Decrypt";
            // 
            // txtDec
            // 
            this.txtDec.Location = new System.Drawing.Point(12, 154);
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(203, 74);
            this.txtDec.TabIndex = 5;
            this.txtDec.Text = "";
            this.txtDec.TextChanged += new System.EventHandler(this.txtDec_TextChanged);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 240);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnc);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtEnc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtEncrypted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtDecrypted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDec;
    }
}