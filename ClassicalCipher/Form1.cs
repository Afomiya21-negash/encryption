using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassicalCiphers.Interfaces;
using ClassicalCipher.Cipher;
using ClassicalCipher.Cipher.CipherSubstitution;
using ClassicalCiphers.Utilities;
using ClassicalCipher.Cipher.CipherSubstitution;
using ClassicalCipher.Cipher.CipherTranspostion;
using ClassicalCiphers.Ciphers;
using ClassicalCiphers.Utilities;

namespace ClassicalCiphers
{
    public partial class Form1 : Form
    {
        // Lists to store available ciphers
        private List<InCipher> substitutionCiphers;
        private List<InCipher> transpositionCiphers;

        public Form1()
        {
            InitializeComponent();

            // Initialize cipher lists
            substitutionCiphers = new List<InCipher>();
            transpositionCiphers = new List<InCipher>();

            // Initialize ciphers
            InitializeCiphers();

            // Populate combo boxes
            PopulateComboBoxes();

            // Populate information tab
            PopulateInformationTab();
        }

        private void InitializeCiphers()
        {
            // Initialize substitution ciphers with default parameters
            substitutionCiphers.Add(new CaesarCipher(3));
            substitutionCiphers.Add(new VigenereCipher("CIPHER"));
            substitutionCiphers.Add(new MonoalphabeticCipher("QWERTYUIOPASDFGHJKLZXCVBNM"));

            // Initialize transposition ciphers with default parameters
            transpositionCiphers.Add(new ColumnarTranspositionCipher("CRYPTO"));
            transpositionCiphers.Add(new RailFenceCipher(3));
            transpositionCiphers.Add(new RouteCipher(4, 5, RouteCipher.RouteDirection.Spiral));
        }

        private void PopulateComboBoxes()
        {
            // Clear combo boxes
            cmbSubstitutionEncrypt.Items.Clear();
            cmbTranspositionEncrypt.Items.Clear();
            cmbSubstitutionDecrypt.Items.Clear();
            cmbTranspositionDecrypt.Items.Clear();

            // Add substitution ciphers to combo boxes
            foreach (InCipher cipher in substitutionCiphers)
            {
                cmbSubstitutionEncrypt.Items.Add(cipher.Name);
                cmbSubstitutionDecrypt.Items.Add(cipher.Name);
            }

            // Add transposition ciphers to combo boxes
            foreach (InCipher cipher in transpositionCiphers)
            {
                cmbTranspositionEncrypt.Items.Add(cipher.Name);
                cmbTranspositionDecrypt.Items.Add(cipher.Name);
            }

            // Select first item in each combo box
            if (cmbSubstitutionEncrypt.Items.Count > 0)
            {
                cmbSubstitutionEncrypt.SelectedIndex = 0;
                cmbSubstitutionDecrypt.SelectedIndex = 0;
            }

            if (cmbTranspositionEncrypt.Items.Count > 0)
            {
                cmbTranspositionEncrypt.SelectedIndex = 0;
                cmbTranspositionDecrypt.SelectedIndex = 0;
            }
        }

        private void PopulateInformationTab()
        {
            rtbInformation.Clear();

            // Add header
            rtbInformation.AppendText("Classical Cipher Application\n");
            rtbInformation.AppendText("============================\n\n");

            // Add substitution cipher information
            rtbInformation.AppendText("Substitution Ciphers:\n");
            rtbInformation.AppendText("--------------------\n");
            foreach (InCipher cipher in substitutionCiphers)
            {
                rtbInformation.AppendText($"- {cipher.Name}: {CipherUtils.GetCipherDescription(cipher.GetType().Name)}\n");
            }

            // Add transposition cipher information
            rtbInformation.AppendText("\nTransposition Ciphers:\n");
            rtbInformation.AppendText("---------------------\n");
            foreach (InCipher cipher in transpositionCiphers)
            {
                rtbInformation.AppendText($"- {cipher.Name}: {CipherUtils.GetCipherDescription(cipher.GetType().Name)}\n");
            }

            // Add combined cipher information
            rtbInformation.AppendText("\nCombined Ciphers:\n");
            rtbInformation.AppendText("----------------\n");
            rtbInformation.AppendText("The application combines a substitution cipher with a transposition cipher for enhanced security.\n");
            rtbInformation.AppendText("For encryption: First applies substitution, then transposition.\n");
            rtbInformation.AppendText("For decryption: First reverses transposition, then reverses substitution.\n");
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtPlaintext.Text))
            {
                MessageBox.Show("Please enter text to encrypt.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected ciphers
            if (cmbSubstitutionEncrypt.SelectedIndex < 0 || cmbTranspositionEncrypt.SelectedIndex < 0)
            {
                MessageBox.Show("Please select both a substitution and a transposition cipher.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InCipher selectedSubCipher = substitutionCiphers[cmbSubstitutionEncrypt.SelectedIndex];
            InCipher selectedTransCipher = transpositionCiphers[cmbTranspositionEncrypt.SelectedIndex];

            // Create combined cipher
            CombinedCipher combinedCipher = new CombinedCipher(selectedSubCipher, selectedTransCipher);

            try
            {
                // Encrypt the text
                string plaintext = txtPlaintext.Text;
                string encrypted = combinedCipher.Encrypt(plaintext);
                txtEncryptResult.Text = encrypted;

                // Verify by decrypting
                string verified = combinedCipher.Decrypt(encrypted);
                txtEncryptVerification.Text = verified;

                // Check if verification was successful
                if (verified == plaintext)
                {
                    txtEncryptVerification.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    txtEncryptVerification.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during encryption: {ex.Message}", "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtCiphertext.Text))
            {
                MessageBox.Show("Please enter text to decrypt.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected ciphers
            if (cmbSubstitutionDecrypt.SelectedIndex < 0 || cmbTranspositionDecrypt.SelectedIndex < 0)
            {
                MessageBox.Show("Please select both a substitution and a transposition cipher.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InCipher selectedSubCipher = substitutionCiphers[cmbSubstitutionDecrypt.SelectedIndex];
            InCipher selectedTransCipher = transpositionCiphers[cmbTranspositionDecrypt.SelectedIndex];

            // Create combined cipher
            CombinedCipher combinedCipher = new CombinedCipher(selectedSubCipher, selectedTransCipher);

            try
            {
                // Decrypt the text
                string ciphertext = txtCiphertext.Text;
                string decrypted = combinedCipher.Decrypt(ciphertext);
                txtDecryptResult.Text = decrypted;

                // Verify by encrypting
                string verified = combinedCipher.Encrypt(decrypted);
                txtDecryptVerification.Text = verified;

                // Check if verification was successful
                if (verified == ciphertext)
                {
                    txtDecryptVerification.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    txtDecryptVerification.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during decryption: {ex.Message}", "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}