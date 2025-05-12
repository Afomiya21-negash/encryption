using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassicalCiphers.Interfaces;

namespace ClassicalCipher.Cipher.CipherSubstitution
{
    public class MonoalphabeticCipher : InCipher
    {
        private readonly Dictionary<char, char> _encryptMap;
        private readonly Dictionary<char, char> _decryptMap;
        private readonly string _key;
        public string Name => "Monoalphabetic Substitution Cipher";
        public CipherType Type => CipherType.Substitution;

        public MonoalphabeticCipher(string key)
        {
            if (string.IsNullOrEmpty(key) || key.Length != 26 || !key.All(char.IsLetter) || key.ToUpper().Distinct().Count() != 26)
                throw new ArgumentException("Key must be a permutation of all 26 letters", nameof(key));

            _key = key.ToUpper();
            _encryptMap = new Dictionary<char, char>();
            _decryptMap = new Dictionary<char, char>();

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < 26; i++)
            {
                _encryptMap[alphabet[i]] = key[i];
                _decryptMap[key[i]] = alphabet[i];

                // Also map lowercase letters
                _encryptMap[char.ToLower(alphabet[i])] = char.ToLower(key[i]);
                _decryptMap[char.ToLower(key[i])] = char.ToLower(alphabet[i]);
            }
        }

        public string Encrypt(string plaintext)
        {
            if (string.IsNullOrEmpty(plaintext))
                return plaintext;

            StringBuilder result = new StringBuilder();

            foreach (char c in plaintext)
            {
                if (_encryptMap.ContainsKey(c))
                {
                    result.Append(_encryptMap[c]);
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

            foreach (char c in ciphertext)
            {
                if (_decryptMap.ContainsKey(c))
                {
                    result.Append(_decryptMap[c]);
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