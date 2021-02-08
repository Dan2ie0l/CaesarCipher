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
            this.txtdecr = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNormal
            // 
            this.txtNormal.Location = new System.Drawing.Point(89, 56);
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(304, 20);
            this.txtNormal.TabIndex = 0;
            // 
            // txtCrypted
            // 
            this.txtCrypted.Location = new System.Drawing.Point(89, 154);
            this.txtCrypted.Name = "txtCrypted";
            this.txtCrypted.Size = new System.Drawing.Size(304, 20);
            this.txtCrypted.TabIndex = 3;
            // 
            // btnec
            // 
            this.btnec.Location = new System.Drawing.Point(161, 212);
            this.btnec.Name = "btnec";
            this.btnec.Size = new System.Drawing.Size(146, 31);
            this.btnec.TabIndex = 4;
            this.btnec.Text = "Encryption";
            this.btnec.UseVisualStyleBackColor = true;
            this.btnec.Click += new System.EventHandler(this.btnec_Click);
            // 
            // btndec
            // 
            this.btndec.Location = new System.Drawing.Point(740, 112);
            this.btndec.Name = "btndec";
            this.btndec.Size = new System.Drawing.Size(146, 31);
            this.btndec.TabIndex = 5;
            this.btndec.Text = "Decryption";
            this.btndec.UseVisualStyleBackColor = true;
            this.btndec.Click += new System.EventHandler(this.btndec_Click);
            // 
            // txtCrypted2
            // 
            this.txtCrypted2.Location = new System.Drawing.Point(557, 50);
            this.txtCrypted2.Name = "txtCrypted2";
            this.txtCrypted2.Size = new System.Drawing.Size(358, 20);
            this.txtCrypted2.TabIndex = 6;
            // 
            // lstNormal
            // 
            this.lstNormal.FormattingEnabled = true;
            this.lstNormal.Location = new System.Drawing.Point(557, 192);
            this.lstNormal.Name = "lstNormal";
            this.lstNormal.Size = new System.Drawing.Size(358, 251);
            this.lstNormal.TabIndex = 9;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(194, 105);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(84, 20);
            this.txtNumber.TabIndex = 10;
            // 
            // txtdecr
            // 
            this.txtdecr.Location = new System.Drawing.Point(557, 166);
            this.txtdecr.Name = "txtdecr";
            this.txtdecr.Size = new System.Drawing.Size(358, 20);
            this.txtdecr.TabIndex = 11;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(624, 118);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(84, 20);
            this.txtNumber2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "NormalText:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "DecryptedText:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Shrift:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Shrift:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "EncryptedText:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "EncryptedText:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtdecr);
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
        private System.Windows.Forms.TextBox txtdecr;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

