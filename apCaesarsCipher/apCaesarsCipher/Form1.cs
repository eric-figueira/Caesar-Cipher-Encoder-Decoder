using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCaesarsCipher
{
    public partial class frmCifra : Form
    {
        public frmCifra()
        {
            InitializeComponent();
        }

        string[] alphabet = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        private void btnEncode_Click(object sender, EventArgs e)
        {
            string passed_string = txtString.Text;

            if (passed_string == "")
                MessageBox.Show("Passed String Must Be Valid!");
            else
            {
                int key;

                if (cbKey.SelectedItem != null)
                {
                    if (int.TryParse(cbKey.SelectedItem.ToString(), out key))
                    {
                        if (key < 1 || key > 25)
                            MessageBox.Show("Invalid Key!");
                        else
                        {
                            string ret = "";
                            passed_string = passed_string.ToLower();
                            foreach (char letter in passed_string)
                            {
                                if (Char.IsLetter(letter))
                                {
                                    string let = Char.ToString(letter);
                                    int alphabet_letter_index = Array.IndexOf(alphabet, let);
                                    int new_index = alphabet_letter_index + key;

                                    if (new_index >= alphabet.Length)
                                        new_index = new_index - alphabet.Length;

                                    ret += alphabet[new_index];
                                }
                                else
                                    ret += letter;
                            }

                            lbResult.Text = ret;
                        }
                    }
                    else
                        MessageBox.Show("Invalid Key!");
                }
                else
                    MessageBox.Show("Invalid Key!");
            }
        }
    }
}
