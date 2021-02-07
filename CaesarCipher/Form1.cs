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

        private void btnec_Click(object sender, EventArgs e)
        {
            string text = Convert.ToString(txtNormal.Text);
            int shift = int.Parse(txtNumber.Text);
           
            char[] alphabet = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] arr = text.ToCharArray();

            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == alphabet[i])
                        arr[j] = alphabet[(i + shift) % alphabet.Length];
                    break;
                }
            }


            string word = new string(arr);
            txtCrypted.Text = Convert.ToString(word);

        }
    }
}
