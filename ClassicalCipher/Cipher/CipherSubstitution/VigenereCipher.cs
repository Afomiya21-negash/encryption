using System;
using System.Linq;
using System.Text;
using ClassicalCiphers.Interfaces;

namespace ClassicalCipher.Cipher.CipherSubstitution
{
    public class VigenereCipher : InCipher
    {
        private readonly string _key;
        public string Name => $"Vigenère Cipher (Key: {_key})";
        public CipherType Type => CipherType.Substitution;

        public VigenereCipher(string key)
        {
            if (string.IsNullOrEmpty(key) || !key.All(char.IsLetter))
                throw new ArgumentException("Key must contain only letters", nameof(key));

            _key = key.ToUpper();
        }

        public string Encrypt(string plaintext)
        {
            if (string.IsNullOrEmpty(plaintext))
                return plaintext;

            StringBuilder result = new StringBuilder();
            int keyIndex = 0;

            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    int shift = _key[keyIndex % _key.Length] - 'A';
                    result.Append((char)((c - offset + shift) % 26 + offset));
                    keyIndex++;
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

            StringBuilder result = new StringBuilder();
            int keyIndex = 0;

            foreach (char c in ciphertext)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    int shift = _key[keyIndex % _key.Length] - 'A';
                    result.Append((char)((c - offset - shift + 26) % 26 + offset));
                    keyIndex++;
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}