using System;
using System.Text;
using ClassicalCiphers.Interfaces;

namespace ClassicalCipher.Cipher.CipherTranspostion
{
    public class RailFenceCipher : InCipher
    {
        private readonly int _rails;
        public string Name => $"Rail Fence Cipher (Rails: {_rails})";
        public CipherType Type => CipherType.Transposition;

        public RailFenceCipher(int rails)
        {
            if (rails < 2)
                throw new ArgumentException("Number of rails must be at least 2", nameof(rails));

            _rails = rails;
        }

        public string Encrypt(string plaintext)
        {
            if (string.IsNullOrEmpty(plaintext))
                return plaintext;

            // Create the rail fence pattern
            char[][] fence = new char[_rails][];
            for (int i = 0; i < _rails; i++)
            {
                fence[i] = new char[plaintext.Length];
                for (int j = 0; j < plaintext.Length; j++)
                {
                    fence[i][j] = '\0';
                }
            }

            // Fill the fence with characters
            int row = 0;
            int direction = 1; // 1 for down, -1 for up

            for (int i = 0; i < plaintext.Length; i++)
            {
                fence[row][i] = plaintext[i];

                if (row == 0)
                    direction = 1;
                else if (row == _rails - 1)
                    direction = -1;

                row += direction;
            }

            // Read off the fence
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < _rails; i++)
            {
                for (int j = 0; j < plaintext.Length; j++)
                {
                    if (fence[i][j] != '\0')
                    {
                        result.Append(fence[i][j]);
                    }
                }
            }

            return result.ToString();
        }

        public string Decrypt(string ciphertext)
        {
            if (string.IsNullOrEmpty(ciphertext))
                return ciphertext;

            // Create the rail fence pattern
            char[][] fence = new char[_rails][];
            for (int i = 0; i < _rails; i++)
            {
                fence[i] = new char[ciphertext.Length];
                for (int j = 0; j < ciphertext.Length; j++)
                {
                    fence[i][j] = '\0';
                }
            }

            // Mark the positions where characters will be placed
            int row = 0;
            int direction = 1;

            for (int i = 0; i < ciphertext.Length; i++)
            {
                fence[row][i] = '*'; // Mark position

                if (row == 0)
                    direction = 1;
                else if (row == _rails - 1)
                    direction = -1;

                row += direction;
            }

            // Fill the fence with ciphertext characters
            int charIndex = 0;
            for (int i = 0; i < _rails; i++)
            {
                for (int j = 0; j < ciphertext.Length; j++)
                {
                    if (fence[i][j] == '*' && charIndex < ciphertext.Length)
                    {
                        fence[i][j] = ciphertext[charIndex++];
                    }
                }
            }

            // Read off the fence in zigzag order
            StringBuilder result = new StringBuilder();
            row = 0;
            direction = 1;

            for (int i = 0; i < ciphertext.Length; i++)
            {
                result.Append(fence[row][i]);

                if (row == 0)
                    direction = 1;
                else if (row == _rails - 1)
                    direction = -1;

                row += direction;
            }

            return result.ToString();
        }
    }
}