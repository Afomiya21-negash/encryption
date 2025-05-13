using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClassicalCiphers.Interfaces;
using ClassicalCipher.Cipher;
using ClassicalCipher.Cipher.CipherSubstitution;

using ClassicalCiphers.Utilities;
using ClassicalCipher.Cipher.CipherSubstitution;
using ClassicalCipher.Cipher.CipherTranspostion;
using ClassicalCiphers.Ciphers;

namespace ClassicalCiphers
{
    public partial class Form1 : Form
    {
        // Lists to store available cipher types (not instances)
        private List<string> substitutionCipherTypes;
        private List<string> transpositionCipherTypes;

        public Form1()
        {
            // Initialize the form's controls and layout
            InitializeComponent();

            // Initialize cipher type lists
            substitutionCipherTypes = new List<string>();
            transpositionCipherTypes = new List<string>();

            // Initialize cipher types
            InitializeCipherTypes();

            // Populate combo boxes with cipher types
            PopulateComboBoxes();

            // Populate information tab with cipher descriptions
            PopulateInformationTab();

            // Set default values for key inputs
            SetDefaultKeyValues();

            // Add event handlers for cipher type selection changes
            cmbSubstitutionEncrypt.SelectedIndexChanged += CipherTypeChanged;
            cmbTranspositionEncrypt.SelectedIndexChanged += CipherTypeChanged;
            cmbSubstitutionDecrypt.SelectedIndexChanged += CipherTypeChanged;
            cmbTranspositionDecrypt.SelectedIndexChanged += CipherTypeChanged;
        }

        // Initialize the lists of available cipher types
        private void InitializeCipherTypes()
        {
            // Add substitution cipher types
            substitutionCipherTypes.Add("Caesar Cipher");
            substitutionCipherTypes.Add("Vigenère Cipher");
            substitutionCipherTypes.Add("Monoalphabetic Substitution Cipher");

            // Add transposition cipher types
            transpositionCipherTypes.Add("Columnar Transposition Cipher");
            transpositionCipherTypes.Add("Rail Fence Cipher");
            transpositionCipherTypes.Add("Route Cipher");
        }

        // Populate the combo boxes with the available cipher types
        private void PopulateComboBoxes()
        {
            // Clear combo boxes
            cmbSubstitutionEncrypt.Items.Clear();
            cmbTranspositionEncrypt.Items.Clear();
            cmbSubstitutionDecrypt.Items.Clear();
            cmbTranspositionDecrypt.Items.Clear();

            // Add substitution cipher types to combo boxes
            foreach (string cipherType in substitutionCipherTypes)
            {
                cmbSubstitutionEncrypt.Items.Add(cipherType);
                cmbSubstitutionDecrypt.Items.Add(cipherType);
            }

            // Add transposition cipher types to combo boxes
            foreach (string cipherType in transpositionCipherTypes)
            {
                cmbTranspositionEncrypt.Items.Add(cipherType);
                cmbTranspositionDecrypt.Items.Add(cipherType);
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

        // Set default values for key inputs based on selected cipher types
        private void SetDefaultKeyValues()
        {
            // Set default values for encryption keys
            UpdateKeyInputs(cmbSubstitutionEncrypt, txtSubstitutionKeyEncrypt, lblSubstitutionKeyEncrypt);
            UpdateKeyInputs(cmbTranspositionEncrypt, txtTranspositionKeyEncrypt, lblTranspositionKeyEncrypt);

            // Set default values for decryption keys
            UpdateKeyInputs(cmbSubstitutionDecrypt, txtSubstitutionKeyDecrypt, lblSubstitutionKeyDecrypt);
            UpdateKeyInputs(cmbTranspositionDecrypt, txtTranspositionKeyDecrypt, lblTranspositionKeyDecrypt);
        }

        // Event handler for when a cipher type is changed
        private void CipherTypeChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            // Update the appropriate key input based on which combo box changed
            if (comboBox == cmbSubstitutionEncrypt)
            {
                UpdateKeyInputs(cmbSubstitutionEncrypt, txtSubstitutionKeyEncrypt, lblSubstitutionKeyEncrypt);
            }
            else if (comboBox == cmbTranspositionEncrypt)
            {
                UpdateKeyInputs(cmbTranspositionEncrypt, txtTranspositionKeyEncrypt, lblTranspositionKeyEncrypt);
            }
            else if (comboBox == cmbSubstitutionDecrypt)
            {
                UpdateKeyInputs(cmbSubstitutionDecrypt, txtSubstitutionKeyDecrypt, lblSubstitutionKeyDecrypt);
            }
            else if (comboBox == cmbTranspositionDecrypt)
            {
                UpdateKeyInputs(cmbTranspositionDecrypt, txtTranspositionKeyDecrypt, lblTranspositionKeyDecrypt);
            }
        }

        // Update key input fields based on the selected cipher type
        private void UpdateKeyInputs(ComboBox cipherTypeComboBox, TextBox keyTextBox, Label keyLabel)
        {
            if (cipherTypeComboBox.SelectedIndex < 0)
                return;

            string selectedCipherType = cipherTypeComboBox.SelectedItem.ToString();

            // Set appropriate label text and default value based on cipher type
            switch (selectedCipherType)
            {
                case "Caesar Cipher":
                    keyLabel.Text = "Shift Value (1-25):";
                    keyTextBox.Text = "3";
                    break;

                case "Vigenère Cipher":
                    keyLabel.Text = "Keyword:";
                    keyTextBox.Text = "CIPHER";
                    break;

                case "Monoalphabetic Substitution Cipher":
                    keyLabel.Text = "Substitution Alphabet (26 letters):";
                    keyTextBox.Text = "QWERTYUIOPASDFGHJKLZXCVBNM";
                    break;

                case "Columnar Transposition Cipher":
                    keyLabel.Text = "Keyword:";
                    keyTextBox.Text = "CRYPTO";
                    break;

                case "Rail Fence Cipher":
                    keyLabel.Text = "Number of Rails (2+):";
                    keyTextBox.Text = "3";
                    break;

                case "Route Cipher":
                    keyLabel.Text = "Dimensions (rows,cols) and Type (S/Z):";
                    keyTextBox.Text = "4,5,S";
                    break;
            }
        }

        // Populate the information tab with descriptions of each cipher
        private void PopulateInformationTab()
        {
            rtbInformation.Clear();

            // Add header
            rtbInformation.AppendText("Classical Cipher Application\n");
            rtbInformation.AppendText("============================\n\n");

            // Add substitution cipher information
            rtbInformation.AppendText("Substitution Ciphers:\n");
            rtbInformation.AppendText("--------------------\n");
            rtbInformation.AppendText("- Caesar Cipher: Shifts each letter in the plaintext by a fixed number of positions in the alphabet.\n");
            rtbInformation.AppendText("- Vigenère Cipher: Uses a keyword to determine variable shifts for each letter in the plaintext.\n");
            rtbInformation.AppendText("- Monoalphabetic Substitution Cipher: Substitutes each letter in the plaintext with another letter according to a fixed mapping.\n\n");

            // Add transposition cipher information
            rtbInformation.AppendText("Transposition Ciphers:\n");
            rtbInformation.AppendText("---------------------\n");
            rtbInformation.AppendText("- Columnar Transposition Cipher: Arranges the plaintext in a grid and reads it column by column according to a key.\n");
            rtbInformation.AppendText("- Rail Fence Cipher: Writes the plaintext in a zigzag pattern across multiple 'rails' and reads off by rows.\n");
            rtbInformation.AppendText("- Route Cipher: Arranges the plaintext in a grid and reads it following a specific route pattern.\n\n");

            // Add combined cipher information
            rtbInformation.AppendText("Combined Ciphers:\n");
            rtbInformation.AppendText("----------------\n");
            rtbInformation.AppendText("The application combines a substitution cipher with a transposition cipher for enhanced security.\n");
            rtbInformation.AppendText("For encryption: First applies substitution, then transposition.\n");
            rtbInformation.AppendText("For decryption: First reverses transposition, then reverses substitution.\n\n");

            // Add key information
            rtbInformation.AppendText("Key Information:\n");
            rtbInformation.AppendText("--------------\n");
            rtbInformation.AppendText("- Caesar Cipher: Enter a shift value between 1 and 25.\n");
            rtbInformation.AppendText("- Vigenère Cipher: Enter a keyword using only letters.\n");
            rtbInformation.AppendText("- Monoalphabetic Substitution: Enter all 26 letters of the alphabet in your desired order.\n");
            rtbInformation.AppendText("- Columnar Transposition: Enter a keyword using only letters.\n");
            rtbInformation.AppendText("- Rail Fence: Enter the number of rails (at least 2).\n");
            rtbInformation.AppendText("- Route Cipher: Enter dimensions and type in format 'rows,cols,type' where type is 'S' for Spiral or 'Z' for Zigzag.\n");
        }

        // Create a substitution cipher based on the selected type and key
        private InCipher CreateSubstitutionCipher(string cipherType, string key)
        {
            switch (cipherType)
            {
                case "Caesar Cipher":
                    // Parse the shift value, default to 3 if invalid
                    if (!int.TryParse(key, out int shift) || shift < 1 || shift > 25)
                    {
                        MessageBox.Show("Invalid shift value. Using default value of 3.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        shift = 3;
                    }
                    return new CaesarCipher(shift);

                case "Vigenère Cipher":
                    // Validate the key contains only letters
                    if (string.IsNullOrEmpty(key) || !System.Text.RegularExpressions.Regex.IsMatch(key, "^[a-zA-Z]+$"))
                    {
                        MessageBox.Show("Invalid keyword. Using default value of 'CIPHER'.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        key = "CIPHER";
                    }
                    return new VigenereCipher(key);

                case "Monoalphabetic Substitution Cipher":
                    // Validate the key is a permutation of the alphabet
                    if (string.IsNullOrEmpty(key) || key.Length != 26 || !IsValidSubstitutionAlphabet(key))
                    {
                        MessageBox.Show("Invalid substitution alphabet. Using default alphabet.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        key = "QWERTYUIOPASDFGHJKLZXCVBNM";
                    }
                    return new MonoalphabeticCipher(key);

                default:
                    // Default to Caesar cipher if type is unknown
                    MessageBox.Show("Unknown substitution cipher type. Using Caesar Cipher.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return new CaesarCipher(3);
            }
        }

        // Create a transposition cipher based on the selected type and key
        private InCipher CreateTranspositionCipher(string cipherType, string key)
        {
            switch (cipherType)
            {
                case "Columnar Transposition Cipher":
                    // Validate the key contains only letters
                    if (string.IsNullOrEmpty(key) || !System.Text.RegularExpressions.Regex.IsMatch(key, "^[a-zA-Z]+$"))
                    {
                        MessageBox.Show("Invalid keyword. Using default value of 'CRYPTO'.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        key = "CRYPTO";
                    }
                    return new ColumnarTranspositionCipher(key);

                case "Rail Fence Cipher":
                    // Parse the number of rails, default to 3 if invalid
                    if (!int.TryParse(key, out int rails) || rails < 2)
                    {
                        MessageBox.Show("Invalid number of rails. Using default value of 3.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rails = 3;
                    }
                    return new RailFenceCipher(rails);

                case "Route Cipher":
                    // Parse the route parameters (rows, columns, type)
                    try
                    {
                        string[] parameters = key.Split(',');
                        if (parameters.Length != 3)
                            throw new FormatException("Invalid format");

                        int rows = int.Parse(parameters[0]);
                        int cols = int.Parse(parameters[1]);
                        string routeType = parameters[2].Trim().ToUpper();

                        if (rows < 2 || cols < 2)
                            throw new ArgumentException("Rows and columns must be at least 2");

                        RouteCipher.RouteDirection direction = routeType == "S" ?
                            RouteCipher.RouteDirection.Spiral : RouteCipher.RouteDirection.Zigzag;

                        return new RouteCipher(rows, cols, direction);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid route parameters. Using default values (4,5,Spiral).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return new RouteCipher(4, 5, RouteCipher.RouteDirection.Spiral);
                    }

                default:
                    // Default to Columnar Transposition if type is unknown
                    MessageBox.Show("Unknown transposition cipher type. Using Columnar Transposition.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return new ColumnarTranspositionCipher("CRYPTO");
            }
        }

        // Check if a string is a valid substitution alphabet (contains all 26 letters exactly once)
        private bool IsValidSubstitutionAlphabet(string alphabet)
        {
            // Convert to uppercase for case-insensitive comparison
            alphabet = alphabet.ToUpper();

            // Check if all letters A-Z are present exactly once
            bool[] letterPresent = new bool[26];

            foreach (char c in alphabet)
            {
                if (c < 'A' || c > 'Z')
                    return false;

                int index = c - 'A';
                if (letterPresent[index])
                    return false; // Letter appears more than once

                letterPresent[index] = true;
            }

            // Check if all letters are present
            for (int i = 0; i < 26; i++)
            {
                if (!letterPresent[i])
                    return false; // Missing at least one letter
            }

            return true;
        }

        // Handle the Encrypt button click event
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtPlaintext.Text))
            {
                MessageBox.Show("Please enter text to encrypt.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected cipher types
            if (cmbSubstitutionEncrypt.SelectedIndex < 0 || cmbTranspositionEncrypt.SelectedIndex < 0)
            {
                MessageBox.Show("Please select both a substitution and a transposition cipher.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get selected cipher types and keys
                string subCipherType = cmbSubstitutionEncrypt.SelectedItem.ToString();
                string subKey = txtSubstitutionKeyEncrypt.Text;
                string transCipherType = cmbTranspositionEncrypt.SelectedItem.ToString();
                string transKey = txtTranspositionKeyEncrypt.Text;

                // Create cipher instances with the provided keys
                InCipher selectedSubCipher = CreateSubstitutionCipher(subCipherType, subKey);
                InCipher selectedTransCipher = CreateTranspositionCipher(transCipherType, transKey);

                // Create combined cipher
                CombinedCipher combinedCipher = new CombinedCipher(selectedSubCipher, selectedTransCipher);

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
                    txtEncryptVerification.BackColor = Color.LightGreen;
                }
                else
                {
                    txtEncryptVerification.BackColor = Color.LightPink;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during encryption: {ex.Message}", "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handle the Decrypt button click event
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtCiphertext.Text))
            {
                MessageBox.Show("Please enter text to decrypt.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected cipher types
            if (cmbSubstitutionDecrypt.SelectedIndex < 0 || cmbTranspositionDecrypt.SelectedIndex < 0)
            {
                MessageBox.Show("Please select both a substitution and a transposition cipher.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get selected cipher types and keys
                string subCipherType = cmbSubstitutionDecrypt.SelectedItem.ToString();
                string subKey = txtSubstitutionKeyDecrypt.Text;
                string transCipherType = cmbTranspositionDecrypt.SelectedItem.ToString();
                string transKey = txtTranspositionKeyDecrypt.Text;

                // Create cipher instances with the provided keys
                InCipher selectedSubCipher = CreateSubstitutionCipher(subCipherType, subKey);
                InCipher selectedTransCipher = CreateTranspositionCipher(transCipherType, transKey);

                // Create combined cipher
                CombinedCipher combinedCipher = new CombinedCipher(selectedSubCipher, selectedTransCipher);

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
                    txtDecryptVerification.BackColor = Color.LightGreen;
                }
                else
                {
                    txtDecryptVerification.BackColor = Color.LightPink;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during decryption: {ex.Message}", "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}