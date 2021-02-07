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
            text = text.ToLower();

            char[] arr = text.ToCharArray();



            for (int i = 0; i < arr.Length; i++)
            {
                char letter = arr[i];

                if (letter != ' ')
                {
                    letter = (char)(letter + shift);
                }
               
                
                if (letter>'z')
                {
                   
                    
                    
                        letter = (char)(letter - 26);
                    
                }
                
                else if (letter < 'a')
                {
                        letter = (char)(letter + 26);
                    
                }
                arr[i] = letter;
               
            }
            string word = new string(arr);
            txtCrypted.Text = Convert.ToString(word);

        }
    }
}
