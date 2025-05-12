using System;
using System.Text;
using ClassicalCiphers.Interfaces;

namespace ClassicalCipher.Cipher.CipherSubstitution
{
    public class CaesarCipher : InCipher
    {
        private readonly int _shift;
        public string Name => $"Caesar Cipher (Shift: {_shift})";
        public CipherType Type => CipherType.Substitution;

        public CaesarCipher(int shift)
        {
            // Ensure shift is within 0-25 range
            _shift = (shift % 26 + 26) % 26;
        }

        public string Encrypt(string plaintext)
        {
            if (string.IsNullOrEmpty(plaintext))
                return plaintext;

            StringBuilder result = new StringBuilder();

            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    result.Append((char)((c - offset + _shift) % 26 + offset));
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        public string Decrypt(string ciphertext)
        {
            if (string.IsNullOrEmpty(ciphertext))
                return ciphertext;

            // For decryption, we use the negative of the shift value
            CaesarCipher decryptCipher = new CaesarCipher(26 - _shift);
            return decryptCipher.Encrypt(ciphertext);
        }
    }
}