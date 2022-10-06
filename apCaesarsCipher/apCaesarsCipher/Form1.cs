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

        string[] alphabet_lower = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string[] alphabet_upper = new string[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

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
                    if (int.TryParse(cbKey.SelectedItem.ToString(), out key)) // Verfiying if key is valid
                    {
                        if (key < 1 || key > 25)
                            MessageBox.Show("Invalid Key!");
                        else
                        {
                            string ret = "";
                            foreach (char letter in passed_string) 
                            {
                                if (Char.IsLetter(letter)) // For each char in passed string test whether is a letter or not
                                {
                                    if (Char.IsLower(letter)) // If it is in lowercase
                                    {
                                        string let = Char.ToString(letter); // Convert to string
                                        int alphabet_letter_index = Array.IndexOf(alphabet_lower, let); // Get the index of the letter in the alphabet
                                        int new_index = alphabet_letter_index + key; // Add the key to the index

                                        if (new_index >= alphabet_lower.Length) // If it is higher than the limit
                                            new_index = new_index - alphabet_lower.Length; // Start from beginning

                                        ret += alphabet_lower[new_index]; // Add the new letter to the string that is going to be returned
                                    }
                                    else // If it is in uppercase
                                    {
                                        string let = Char.ToString(letter); // Convert to string
                                        int alphabet_letter_index = Array.IndexOf(alphabet_upper, let); // Get the index of the letter in the alphabet
                                        int new_index = alphabet_letter_index + key; // Add the key to the index

                                        if (new_index >= alphabet_upper.Length) // If it is higher than the limit
                                            new_index = new_index - alphabet_upper.Length; // Start from beginning

                                        ret += alphabet_upper[new_index]; // Add the new letter to the string that is going to be returned
                                    }
                                }
                                else
                                    ret += letter; // If is not a letter (numbers, symbols, spaces)
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

        private void btnDecode_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
            string encrypted_string = txtEncryptedString.Text;

            if (encrypted_string == "")
                MessageBox.Show("Passed Encrypted String Must Be Valid!");
            else
            {
                for (int key = 0; key < 26; key++)
                {
                    string ret = "";
                    foreach (char letter in encrypted_string)
                    {
                        if (Char.IsLetter(letter))
                        {
                            if (Char.IsLower(letter))
                            {
                                string let = Char.ToString(letter);
                                int alphabet_letter_index = Array.IndexOf(alphabet_lower, let);
                                int new_index = alphabet_letter_index + key;

                                if (new_index >= alphabet_lower.Length)
                                    new_index = new_index - alphabet_lower.Length;

                                ret += alphabet_lower[new_index];
                            }
                            else
                            {
                                string let = Char.ToString(letter);
                                int alphabet_letter_index = Array.IndexOf(alphabet_upper, let);
                                int new_index = alphabet_letter_index + key;

                                if (new_index >= alphabet_upper.Length)
                                    new_index = new_index - alphabet_upper.Length;

                                ret += alphabet_upper[new_index];
                            }
                        }
                        else
                            ret += letter;
                    }

                    listResult.Items.Add("Key " + (key + 1) + ": " + ret);
                }      
            }
        }
    }
}
