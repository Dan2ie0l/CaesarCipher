using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static char Cipher(char ch, int shift)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char letter = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + shift) - letter) % 26) + letter);
        }

        private void btnec_Click(object sender, EventArgs e)
        {
            string text = Convert.ToString(txtNormal.Text);
            int shift = int.Parse(txtNumber.Text);
            string encrypted = "";
            foreach (char ch in text)
            {
                encrypted += Cipher(ch, shift);
            }


            txtCrypted.Text = Convert.ToString(encrypted);

        }

        private void btndec_Click(object sender, EventArgs e)
        {
            string text = Convert.ToString(txtCrypted2.Text);
            string decrypted = "";
            int shift ;
            try
            {
                shift = int.Parse(txtNumber2.Text);
            }
            catch (Exception)
            {

                shift = 0;
            }
           
            string decr = "";
            foreach (char ch in text)
            {
                decr += Cipher(ch, 26 - shift);
            }
            txtdecr.Text = Convert.ToString(decr);
            for (int i = 0; i < 26; i++)
            {
                foreach (char ch in text)
                {
                    decrypted += Cipher(ch, 26 - i);
                }
                lstNormal.Items.Add((decrypted + " ").ToString());
                decrypted = " ";

            }




        }

    }
}
