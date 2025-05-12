using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassicalCiphers.Interfaces;

namespace ClassicalCipher.Cipher.CipherTranspostion
{
    public class ColumnarTranspositionCipher : InCipher
    {
        private readonly string _key;
        private readonly int[] _keyOrder;
        public string Name => $"Columnar Transposition Cipher (Key: {_key})";
        public CipherType Type => CipherType.Transposition;

        public ColumnarTranspositionCipher(string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Key cannot be empty", nameof(key));

            _key = key;
            _keyOrder = GetKeyOrder(key);
        }

        private static int[] GetKeyOrder(string key)
        {
            // Create a dictionary to store the order of each character in the key
            Dictionary<int, int> keyMap = new Dictionary<int, int>();

            // Convert key to char array and sort it
            char[] sortedKey = key.ToCharArray();
            Array.Sort(sortedKey);

            // Create a mapping from the original key to the sorted positions
            for (int i = 0; i < sortedKey.Length; i++)
            {
                int position = key.IndexOf(sortedKey[i]);
                while (keyMap.ContainsKey(position))
                {
                    position = key.IndexOf(sortedKey[i], position + 1);
                }
                keyMap[position] = i;
            }

            // Convert the mapping to an array
            return keyMap.OrderBy(x => x.Key).Select(x => x.Value).ToArray();
        }

        public string Encrypt(string plaintext)
        {
            if (string.IsNullOrEmpty(plaintext))
                return plaintext;

            // Calculate number of rows needed
            int numRows = (int)Math.Ceiling((double)plaintext.Length / _key.Length);

            // Create a matrix to hold the plaintext
            char[,] matrix = new char[numRows, _key.Length];

            // Fill the matrix with the plaintext
            int charIndex = 0;
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < _key.Length; col++)
                {
                    if (charIndex < plaintext.Length)
                    {
                        matrix[row, col] = plaintext[charIndex++];
                    }
                    else
                    {
                        // Pad with 'X' if needed
                        matrix[row, col] = 'X';
                    }
                }
            }

            // Read the matrix column by column according to the key order
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < _key.Length; i++)
            {
                int col = Array.IndexOf(_keyOrder, i);
                for (int row = 0; row < numRows; row++)
                {
                    result.Append(matrix[row, col]);
                }
            }

            return result.ToString();
        }

        public string Decrypt(string ciphertext)
        {
            if (string.IsNullOrEmpty(ciphertext))
                return ciphertext;

            // Calculate number of rows needed
            int numRows = (int)Math.Ceiling((double)ciphertext.Length / _key.Length);
            int numCols = _key.Length;

            // Create a matrix to hold the ciphertext
            char[,] matrix = new char[numRows, numCols];

            // Fill the matrix column by column according to the key order
            int charIndex = 0;
            for (int i = 0; i < numCols; i++)
            {
                int col = Array.IndexOf(_keyOrder, i);
                for (int row = 0; row < numRows; row++)
                {
                    if (charIndex < ciphertext.Length)
                    {
                        matrix[row, col] = ciphertext[charIndex++];
                    }
                }
            }

            // Read the matrix row by row to get the plaintext
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    // Skip padding characters
                    if (matrix[row, col] != '\0' && matrix[row, col] != 'X')
                    {
                        result.Append(matrix[row, col]);
                    }
                }
            }

            return result.ToString();
        }
    }
}