namespace ClassicalCiphers
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabEncrypt = new System.Windows.Forms.TabPage();
            this.grpEncryptVerification = new System.Windows.Forms.GroupBox();
            this.txtEncryptVerification = new System.Windows.Forms.TextBox();
            this.lblEncryptVerification = new System.Windows.Forms.Label();
            this.grpEncryptResult = new System.Windows.Forms.GroupBox();
            this.txtEncryptResult = new System.Windows.Forms.TextBox();
            this.lblEncryptResult = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.grpPlaintext = new System.Windows.Forms.GroupBox();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.lblPlaintext = new System.Windows.Forms.Label();
            this.grpTranspositionEncrypt = new System.Windows.Forms.GroupBox();
            this.cmbTranspositionEncrypt = new System.Windows.Forms.ComboBox();
            this.lblTranspositionEncrypt = new System.Windows.Forms.Label();
            this.grpSubstitutionEncrypt = new System.Windows.Forms.GroupBox();
            this.cmbSubstitutionEncrypt = new System.Windows.Forms.ComboBox();
            this.lblSubstitutionEncrypt = new System.Windows.Forms.Label();
            this.tabDecrypt = new System.Windows.Forms.TabPage();
            this.grpDecryptVerification = new System.Windows.Forms.GroupBox();
            this.txtDecryptVerification = new System.Windows.Forms.TextBox();
            this.lblDecryptVerification = new System.Windows.Forms.Label();
            this.grpDecryptResult = new System.Windows.Forms.GroupBox();
            this.txtDecryptResult = new System.Windows.Forms.TextBox();
            this.lblDecryptResult = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.grpCiphertext = new System.Windows.Forms.GroupBox();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.lblCiphertext = new System.Windows.Forms.Label();
            this.grpTranspositionDecrypt = new System.Windows.Forms.GroupBox();
            this.cmbTranspositionDecrypt = new System.Windows.Forms.ComboBox();
            this.lblTranspositionDecrypt = new System.Windows.Forms.Label();
            this.grpSubstitutionDecrypt = new System.Windows.Forms.GroupBox();
            this.cmbSubstitutionDecrypt = new System.Windows.Forms.ComboBox();
            this.lblSubstitutionDecrypt = new System.Windows.Forms.Label();
            this.tabInformation = new System.Windows.Forms.TabPage();
            this.rtbInformation = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.tabEncrypt.SuspendLayout();
            this.grpEncryptVerification.SuspendLayout();
            this.grpEncryptResult.SuspendLayout();
            this.grpPlaintext.SuspendLayout();
            this.grpTranspositionEncrypt.SuspendLayout();
            this.grpSubstitutionEncrypt.SuspendLayout();
            this.tabDecrypt.SuspendLayout();
            this.grpDecryptVerification.SuspendLayout();
            this.grpDecryptResult.SuspendLayout();
            this.grpCiphertext.SuspendLayout();
            this.grpTranspositionDecrypt.SuspendLayout();
            this.grpSubstitutionDecrypt.SuspendLayout();
            this.tabInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEncrypt);
            this.tabControl.Controls.Add(this.tabDecrypt);
            this.tabControl.Controls.Add(this.tabInformation);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 561);
            this.tabControl.TabIndex = 0;
            // 
            // tabEncrypt
            // 
            this.tabEncrypt.Controls.Add(this.grpEncryptVerification);
            this.tabEncrypt.Controls.Add(this.grpEncryptResult);
            this.tabEncrypt.Controls.Add(this.btnEncrypt);
            this.tabEncrypt.Controls.Add(this.grpPlaintext);
            this.tabEncrypt.Controls.Add(this.grpTranspositionEncrypt);
            this.tabEncrypt.Controls.Add(this.grpSubstitutionEncrypt);
            this.tabEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tabEncrypt.Name = "tabEncrypt";
            this.tabEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncrypt.Size = new System.Drawing.Size(776, 535);
            this.tabEncrypt.TabIndex = 0;
            this.tabEncrypt.Text = "Encrypt";
            this.tabEncrypt.UseVisualStyleBackColor = true;
            // 
            // grpEncryptVerification
            // 
            this.grpEncryptVerification.Controls.Add(this.txtEncryptVerification);
            this.grpEncryptVerification.Controls.Add(this.lblEncryptVerification);
            this.grpEncryptVerification.Location = new System.Drawing.Point(20, 400);
            this.grpEncryptVerification.Name = "grpEncryptVerification";
            this.grpEncryptVerification.Size = new System.Drawing.Size(730, 100);
            this.grpEncryptVerification.TabIndex = 5;
            this.grpEncryptVerification.TabStop = false;
            this.grpEncryptVerification.Text = "Verification";
            // 
            // txtEncryptVerification
            // 
            this.txtEncryptVerification.Location = new System.Drawing.Point(10, 45);
            this.txtEncryptVerification.Multiline = true;
            this.txtEncryptVerification.Name = "txtEncryptVerification";
            this.txtEncryptVerification.ReadOnly = true;
            this.txtEncryptVerification.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncryptVerification.Size = new System.Drawing.Size(710, 40);
            this.txtEncryptVerification.TabIndex = 1;
            // 
            // lblEncryptVerification
            // 
            this.lblEncryptVerification.AutoSize = true;
            this.lblEncryptVerification.Location = new System.Drawing.Point(10, 25);
            this.lblEncryptVerification.Name = "lblEncryptVerification";
            this.lblEncryptVerification.Size = new System.Drawing.Size(119, 13);
            this.lblEncryptVerification.TabIndex = 0;
            this.lblEncryptVerification.Text = "Verification (decrypted):";
            // 
            // grpEncryptResult
            // 
            this.grpEncryptResult.Controls.Add(this.txtEncryptResult);
            this.grpEncryptResult.Controls.Add(this.lblEncryptResult);
            this.grpEncryptResult.Location = new System.Drawing.Point(20, 290);
            this.grpEncryptResult.Name = "grpEncryptResult";
            this.grpEncryptResult.Size = new System.Drawing.Size(730, 100);
            this.grpEncryptResult.TabIndex = 4;
            this.grpEncryptResult.TabStop = false;
            this.grpEncryptResult.Text = "Result";
            // 
            // txtEncryptResult
            // 
            this.txtEncryptResult.Location = new System.Drawing.Point(10, 45);
            this.txtEncryptResult.Multiline = true;
            this.txtEncryptResult.Name = "txtEncryptResult";
            this.txtEncryptResult.ReadOnly = true;
            this.txtEncryptResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncryptResult.Size = new System.Drawing.Size(710, 40);
            this.txtEncryptResult.TabIndex = 1;
            // 
            // lblEncryptResult
            // 
            this.lblEncryptResult.AutoSize = true;
            this.lblEncryptResult.Location = new System.Drawing.Point(10, 25);
            this.lblEncryptResult.Name = "lblEncryptResult";
            this.lblEncryptResult.Size = new System.Drawing.Size(79, 13);
            this.lblEncryptResult.TabIndex = 0;
            this.lblEncryptResult.Text = "Encrypted text:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(350, 250);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 30);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // grpPlaintext
            // 
            this.grpPlaintext.Controls.Add(this.txtPlaintext);
            this.grpPlaintext.Controls.Add(this.lblPlaintext);
            this.grpPlaintext.Location = new System.Drawing.Point(20, 120);
            this.grpPlaintext.Name = "grpPlaintext";
            this.grpPlaintext.Size = new System.Drawing.Size(730, 120);
            this.grpPlaintext.TabIndex = 2;
            this.grpPlaintext.TabStop = false;
            this.grpPlaintext.Text = "Text";
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Location = new System.Drawing.Point(10, 45);
            this.txtPlaintext.Multiline = true;
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlaintext.Size = new System.Drawing.Size(710, 60);
            this.txtPlaintext.TabIndex = 1;
            // 
            // lblPlaintext
            // 
            this.lblPlaintext.AutoSize = true;
            this.lblPlaintext.Location = new System.Drawing.Point(10, 25);
            this.lblPlaintext.Name = "lblPlaintext";
            this.lblPlaintext.Size = new System.Drawing.Size(95, 13);
            this.lblPlaintext.TabIndex = 0;
            this.lblPlaintext.Text = "Enter text to encrypt:";
            // 
            // grpTranspositionEncrypt
            // 
            this.grpTranspositionEncrypt.Controls.Add(this.cmbTranspositionEncrypt);
            this.grpTranspositionEncrypt.Controls.Add(this.lblTranspositionEncrypt);
            this.grpTranspositionEncrypt.Location = new System.Drawing.Point(400, 20);
            this.grpTranspositionEncrypt.Name = "grpTranspositionEncrypt";
            this.grpTranspositionEncrypt.Size = new System.Drawing.Size(350, 80);
            this.grpTranspositionEncrypt.TabIndex = 1;
            this.grpTranspositionEncrypt.TabStop = false;
            this.grpTranspositionEncrypt.Text = "Transposition Cipher";
            // 
            // cmbTranspositionEncrypt
            // 
            this.cmbTranspositionEncrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTranspositionEncrypt.FormattingEnabled = true;
            this.cmbTranspositionEncrypt.Location = new System.Drawing.Point(10, 45);
            this.cmbTranspositionEncrypt.Name = "cmbTranspositionEncrypt";
            this.cmbTranspositionEncrypt.Size = new System.Drawing.Size(330, 21);
            this.cmbTranspositionEncrypt.TabIndex = 1;
            // 
            // lblTranspositionEncrypt
            // 
            this.lblTranspositionEncrypt.AutoSize = true;
            this.lblTranspositionEncrypt.Location = new System.Drawing.Point(10, 25);
            this.lblTranspositionEncrypt.Name = "lblTranspositionEncrypt";
            this.lblTranspositionEncrypt.Size = new System.Drawing.Size(134, 13);
            this.lblTranspositionEncrypt.TabIndex = 0;
            this.lblTranspositionEncrypt.Text = "Select Transposition Cipher:";
            // 
            // grpSubstitutionEncrypt
            // 
            this.grpSubstitutionEncrypt.Controls.Add(this.cmbSubstitutionEncrypt);
            this.grpSubstitutionEncrypt.Controls.Add(this.lblSubstitutionEncrypt);
            this.grpSubstitutionEncrypt.Location = new System.Drawing.Point(20, 20);
            this.grpSubstitutionEncrypt.Name = "grpSubstitutionEncrypt";
            this.grpSubstitutionEncrypt.Size = new System.Drawing.Size(350, 80);
            this.grpSubstitutionEncrypt.TabIndex = 0;
            this.grpSubstitutionEncrypt.TabStop = false;
            this.grpSubstitutionEncrypt.Text = "Substitution Cipher";
            // 
            // cmbSubstitutionEncrypt
            // 
            this.cmbSubstitutionEncrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubstitutionEncrypt.FormattingEnabled = true;
            this.cmbSubstitutionEncrypt.Location = new System.Drawing.Point(10, 45);
            this.cmbSubstitutionEncrypt.Name = "cmbSubstitutionEncrypt";
            this.cmbSubstitutionEncrypt.Size = new System.Drawing.Size(330, 21);
            this.cmbSubstitutionEncrypt.TabIndex = 1;
            // 
            // lblSubstitutionEncrypt
            // 
            this.lblSubstitutionEncrypt.AutoSize = true;
            this.lblSubstitutionEncrypt.Location = new System.Drawing.Point(10, 25);
            this.lblSubstitutionEncrypt.Name = "lblSubstitutionEncrypt";
            this.lblSubstitutionEncrypt.Size = new System.Drawing.Size(129, 13);
            this.lblSubstitutionEncrypt.TabIndex = 0;
            this.lblSubstitutionEncrypt.Text = "Select Substitution Cipher:";
            // 
            // tabDecrypt
            // 
            this.tabDecrypt.Controls.Add(this.grpDecryptVerification);
            this.tabDecrypt.Controls.Add(this.grpDecryptResult);
            this.tabDecrypt.Controls.Add(this.btnDecrypt);
            this.tabDecrypt.Controls.Add(this.grpCiphertext);
            this.tabDecrypt.Controls.Add(this.grpTranspositionDecrypt);
            this.tabDecrypt.Controls.Add(this.grpSubstitutionDecrypt);
            this.tabDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tabDecrypt.Name = "tabDecrypt";
            this.tabDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecrypt.Size = new System.Drawing.Size(776, 535);
            this.tabDecrypt.TabIndex = 1;
            this.tabDecrypt.Text = "Decrypt";
            this.tabDecrypt.UseVisualStyleBackColor = true;
            // 
            // grpDecryptVerification
            // 
            this.grpDecryptVerification.Controls.Add(this.txtDecryptVerification);
            this.grpDecryptVerification.Controls.Add(this.lblDecryptVerification);
            this.grpDecryptVerification.Location = new System.Drawing.Point(20, 400);
            this.grpDecryptVerification.Name = "grpDecryptVerification";
            this.grpDecryptVerification.Size = new System.Drawing.Size(730, 100);
            this.grpDecryptVerification.TabIndex = 11;
            this.grpDecryptVerification.TabStop = false;
            this.grpDecryptVerification.Text = "Verification";
            // 
            // txtDecryptVerification
            // 
            this.txtDecryptVerification.Location = new System.Drawing.Point(10, 45);
            this.txtDecryptVerification.Multiline = true;
            this.txtDecryptVerification.Name = "txtDecryptVerification";
            this.txtDecryptVerification.ReadOnly = true;
            this.txtDecryptVerification.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDecryptVerification.Size = new System.Drawing.Size(710, 40);
            this.txtDecryptVerification.TabIndex = 1;
            // 
            // lblDecryptVerification
            // 
            this.lblDecryptVerification.AutoSize = true;
            this.lblDecryptVerification.Location = new System.Drawing.Point(10, 25);
            this.lblDecryptVerification.Name = "lblDecryptVerification";
            this.lblDecryptVerification.Size = new System.Drawing.Size(121, 13);
            this.lblDecryptVerification.TabIndex = 0;
            this.lblDecryptVerification.Text = "Verification (encrypted):";
            // 
            // grpDecryptResult
            // 
            this.grpDecryptResult.Controls.Add(this.txtDecryptResult);
            this.grpDecryptResult.Controls.Add(this.lblDecryptResult);
            this.grpDecryptResult.Location = new System.Drawing.Point(20, 290);
            this.grpDecryptResult.Name = "grpDecryptResult";
            this.grpDecryptResult.Size = new System.Drawing.Size(730, 100);
            this.grpDecryptResult.TabIndex = 10;
            this.grpDecryptResult.TabStop = false;
            this.grpDecryptResult.Text = "Result";
            // 
            // txtDecryptResult
            // 
            this.txtDecryptResult.Location = new System.Drawing.Point(10, 45);
            this.txtDecryptResult.Multiline = true;
            this.txtDecryptResult.Name = "txtDecryptResult";
            this.txtDecryptResult.ReadOnly = true;
            this.txtDecryptResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDecryptResult.Size = new System.Drawing.Size(710, 40);
            this.txtDecryptResult.TabIndex = 1;
            // 
            // lblDecryptResult
            // 
            this.lblDecryptResult.AutoSize = true;
            this.lblDecryptResult.Location = new System.Drawing.Point(10, 25);
            this.lblDecryptResult.Name = "lblDecryptResult";
            this.lblDecryptResult.Size = new System.Drawing.Size(79, 13);
            this.lblDecryptResult.TabIndex = 0;
            this.lblDecryptResult.Text = "Decrypted text:";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(350, 250);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 30);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // grpCiphertext
            // 
            this.grpCiphertext.Controls.Add(this.txtCiphertext);
            this.grpCiphertext.Controls.Add(this.lblCiphertext);
            this.grpCiphertext.Location = new System.Drawing.Point(20, 120);
            this.grpCiphertext.Name = "grpCiphertext";
            this.grpCiphertext.Size = new System.Drawing.Size(730, 120);
            this.grpCiphertext.TabIndex = 8;
            this.grpCiphertext.TabStop = false;
            this.grpCiphertext.Text = "Text";
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.Location = new System.Drawing.Point(10, 45);
            this.txtCiphertext.Multiline = true;
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCiphertext.Size = new System.Drawing.Size(710, 60);
            this.txtCiphertext.TabIndex = 1;
            // 
            // lblCiphertext
            // 
            this.lblCiphertext.AutoSize = true;
            this.lblCiphertext.Location = new System.Drawing.Point(10, 25);
            this.lblCiphertext.Name = "lblCiphertext";
            this.lblCiphertext.Size = new System.Drawing.Size(95, 13);
            this.lblCiphertext.TabIndex = 0;
            this.lblCiphertext.Text = "Enter text to decrypt:";
            // 
            // grpTranspositionDecrypt
            // 
            this.grpTranspositionDecrypt.Controls.Add(this.cmbTranspositionDecrypt);
            this.grpTranspositionDecrypt.Controls.Add(this.lblTranspositionDecrypt);
            this.grpTranspositionDecrypt.Location = new System.Drawing.Point(400, 20);
            this.grpTranspositionDecrypt.Name = "grpTranspositionDecrypt";
            this.grpTranspositionDecrypt.Size = new System.Drawing.Size(350, 80);
            this.grpTranspositionDecrypt.TabIndex = 7;
            this.grpTranspositionDecrypt.TabStop = false;
            this.grpTranspositionDecrypt.Text = "Transposition Cipher";
            // 
            // cmbTranspositionDecrypt
            // 
            this.cmbTranspositionDecrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTranspositionDecrypt.FormattingEnabled = true;
            this.cmbTranspositionDecrypt.Location = new System.Drawing.Point(10, 45);
            this.cmbTranspositionDecrypt.Name = "cmbTranspositionDecrypt";
            this.cmbTranspositionDecrypt.Size = new System.Drawing.Size(330, 21);
            this.cmbTranspositionDecrypt.TabIndex = 1;
            // 
            // lblTranspositionDecrypt
            // 
            this.lblTranspositionDecrypt.AutoSize = true;
            this.lblTranspositionDecrypt.Location = new System.Drawing.Point(10, 25);
            this.lblTranspositionDecrypt.Name = "lblTranspositionDecrypt";
            this.lblTranspositionDecrypt.Size = new System.Drawing.Size(134, 13);
            this.lblTranspositionDecrypt.TabIndex = 0;
            this.lblTranspositionDecrypt.Text = "Select Transposition Cipher:";
            // 
            // grpSubstitutionDecrypt
            // 
            this.grpSubstitutionDecrypt.Controls.Add(this.cmbSubstitutionDecrypt);
            this.grpSubstitutionDecrypt.Controls.Add(this.lblSubstitutionDecrypt);
            this.grpSubstitutionDecrypt.Location = new System.Drawing.Point(20, 20);
            this.grpSubstitutionDecrypt.Name = "grpSubstitutionDecrypt";
            this.grpSubstitutionDecrypt.Size = new System.Drawing.Size(350, 80);
            this.grpSubstitutionDecrypt.TabIndex = 6;
            this.grpSubstitutionDecrypt.TabStop = false;
            this.grpSubstitutionDecrypt.Text = "Substitution Cipher";
            // 
            // cmbSubstitutionDecrypt
            // 
            this.cmbSubstitutionDecrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubstitutionDecrypt.FormattingEnabled = true;
            this.cmbSubstitutionDecrypt.Location = new System.Drawing.Point(10, 45);
            this.cmbSubstitutionDecrypt.Name = "cmbSubstitutionDecrypt";
            this.cmbSubstitutionDecrypt.Size = new System.Drawing.Size(330, 21);
            this.cmbSubstitutionDecrypt.TabIndex = 1;
            // 
            // lblSubstitutionDecrypt
            // 
            this.lblSubstitutionDecrypt.AutoSize = true;
            this.lblSubstitutionDecrypt.Location = new System.Drawing.Point(10, 25);
            this.lblSubstitutionDecrypt.Name = "lblSubstitutionDecrypt";
            this.lblSubstitutionDecrypt.Size = new System.Drawing.Size(129, 13);
            this.lblSubstitutionDecrypt.TabIndex = 0;
            this.lblSubstitutionDecrypt.Text = "Select Substitution Cipher:";
            // 
            // tabInformation
            // 
            this.tabInformation.Controls.Add(this.rtbInformation);
            this.tabInformation.Location = new System.Drawing.Point(4, 22);
            this.tabInformation.Name = "tabInformation";
            this.tabInformation.Size = new System.Drawing.Size(776, 535);
            this.tabInformation.TabIndex = 2;
            this.tabInformation.Text = "Information";
            this.tabInformation.UseVisualStyleBackColor = true;
            // 
            // rtbInformation
            // 
            this.rtbInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInformation.Location = new System.Drawing.Point(0, 0);
            this.rtbInformation.Name = "rtbInformation";
            this.rtbInformation.ReadOnly = true;
            this.rtbInformation.Size = new System.Drawing.Size(776, 535);
            this.rtbInformation.TabIndex = 0;
            this.rtbInformation.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classical Cipher Application";
            this.tabControl.ResumeLayout(false);
            this.tabEncrypt.ResumeLayout(false);
            this.grpEncryptVerification.ResumeLayout(false);
            this.grpEncryptVerification.PerformLayout();
            this.grpEncryptResult.ResumeLayout(false);
            this.grpEncryptResult.PerformLayout();
            this.grpPlaintext.ResumeLayout(false);
            this.grpPlaintext.PerformLayout();
            this.grpTranspositionEncrypt.ResumeLayout(false);
            this.grpTranspositionEncrypt.PerformLayout();
            this.grpSubstitutionEncrypt.ResumeLayout(false);
            this.grpSubstitutionEncrypt.PerformLayout();
            this.tabDecrypt.ResumeLayout(false);
            this.grpDecryptVerification.ResumeLayout(false);
            this.grpDecryptVerification.PerformLayout();
            this.grpDecryptResult.ResumeLayout(false);
            this.grpDecryptResult.PerformLayout();
            this.grpCiphertext.ResumeLayout(false);
            this.grpCiphertext.PerformLayout();
            this.grpTranspositionDecrypt.ResumeLayout(false);
            this.grpTranspositionDecrypt.PerformLayout();
            this.grpSubstitutionDecrypt.ResumeLayout(false);
            this.grpSubstitutionDecrypt.PerformLayout();
            this.tabInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEncrypt;
        private System.Windows.Forms.TabPage tabDecrypt;
        private System.Windows.Forms.TabPage tabInformation;
        private System.Windows.Forms.GroupBox grpSubstitutionEncrypt;
        private System.Windows.Forms.Label lblSubstitutionEncrypt;
        private System.Windows.Forms.ComboBox cmbSubstitutionEncrypt;
        private System.Windows.Forms.GroupBox grpTranspositionEncrypt;
        private System.Windows.Forms.Label lblTranspositionEncrypt;
        private System.Windows.Forms.ComboBox cmbTranspositionEncrypt;
        private System.Windows.Forms.GroupBox grpPlaintext;
        private System.Windows.Forms.Label lblPlaintext;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.GroupBox grpEncryptResult;
        private System.Windows.Forms.Label lblEncryptResult;
        private System.Windows.Forms.TextBox txtEncryptResult;
        private System.Windows.Forms.GroupBox grpEncryptVerification;
        private System.Windows.Forms.Label lblEncryptVerification;
        private System.Windows.Forms.TextBox txtEncryptVerification;
        private System.Windows.Forms.GroupBox grpSubstitutionDecrypt;
        private System.Windows.Forms.Label lblSubstitutionDecrypt;
        private System.Windows.Forms.ComboBox cmbSubstitutionDecrypt;
        private System.Windows.Forms.GroupBox grpTranspositionDecrypt;
        private System.Windows.Forms.Label lblTranspositionDecrypt;
        private System.Windows.Forms.ComboBox cmbTranspositionDecrypt;
        private System.Windows.Forms.GroupBox grpCiphertext;
        private System.Windows.Forms.Label lblCiphertext;
        private System.Windows.Forms.TextBox txtCiphertext;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.GroupBox grpDecryptResult;
        private System.Windows.Forms.Label lblDecryptResult;
        private System.Windows.Forms.TextBox txtDecryptResult;
        private System.Windows.Forms.GroupBox grpDecryptVerification;
        private System.Windows.Forms.Label lblDecryptVerification;
        private System.Windows.Forms.TextBox txtDecryptVerification;
        private System.Windows.Forms.RichTextBox rtbInformation;
    }
}