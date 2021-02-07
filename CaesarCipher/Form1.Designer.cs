namespace CaesarCipher
{
    partial class Form1
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
            this.txtNormal = new System.Windows.Forms.TextBox();
            this.txtCrypted = new System.Windows.Forms.TextBox();
            this.btnec = new System.Windows.Forms.Button();
            this.btndec = new System.Windows.Forms.Button();
            this.txtCrypted2 = new System.Windows.Forms.TextBox();
            this.lstNormal = new System.Windows.Forms.ListBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNormal
            // 
            this.txtNormal.Location = new System.Drawing.Point(12, 71);
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(304, 20);
            this.txtNormal.TabIndex = 0;
            // 
            // txtCrypted
            // 
            this.txtCrypted.Location = new System.Drawing.Point(12, 166);
            this.txtCrypted.Name = "txtCrypted";
            this.txtCrypted.Size = new System.Drawing.Size(304, 20);
            this.txtCrypted.TabIndex = 3;
            // 
            // btnec
            // 
            this.btnec.Location = new System.Drawing.Point(84, 224);
            this.btnec.Name = "btnec";
            this.btnec.Size = new System.Drawing.Size(146, 31);
            this.btnec.TabIndex = 4;
            this.btnec.Text = "Encryption";
            this.btnec.UseVisualStyleBackColor = true;
            this.btnec.Click += new System.EventHandler(this.btnec_Click);
            // 
            // btndec
            // 
            this.btndec.Location = new System.Drawing.Point(472, 123);
            this.btndec.Name = "btndec";
            this.btndec.Size = new System.Drawing.Size(146, 31);
            this.btndec.TabIndex = 5;
            this.btndec.Text = "Decryption";
            this.btndec.UseVisualStyleBackColor = true;
            // 
            // txtCrypted2
            // 
            this.txtCrypted2.Location = new System.Drawing.Point(380, 71);
            this.txtCrypted2.Name = "txtCrypted2";
            this.txtCrypted2.Size = new System.Drawing.Size(358, 20);
            this.txtCrypted2.TabIndex = 6;
            // 
            // lstNormal
            // 
            this.lstNormal.FormattingEnabled = true;
            this.lstNormal.Location = new System.Drawing.Point(380, 199);
            this.lstNormal.Name = "lstNormal";
            this.lstNormal.Size = new System.Drawing.Size(358, 251);
            this.lstNormal.TabIndex = 9;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(115, 123);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(84, 20);
            this.txtNumber.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lstNormal);
            this.Controls.Add(this.txtCrypted2);
            this.Controls.Add(this.btndec);
            this.Controls.Add(this.btnec);
            this.Controls.Add(this.txtCrypted);
            this.Controls.Add(this.txtNormal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNormal;
        private System.Windows.Forms.TextBox txtCrypted;
        private System.Windows.Forms.Button btnec;
        private System.Windows.Forms.Button btndec;
        private System.Windows.Forms.TextBox txtCrypted2;
        private System.Windows.Forms.ListBox lstNormal;
        private System.Windows.Forms.TextBox txtNumber;
    }
}

