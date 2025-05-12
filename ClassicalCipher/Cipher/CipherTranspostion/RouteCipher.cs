using System;
using System.Text;
using ClassicalCiphers.Interfaces;

namespace ClassicalCipher.Cipher.CipherTranspostion
{
    public class RouteCipher : InCipher
    {
        private readonly int _rows;
        private readonly int _cols;
        private readonly RouteDirection _direction;
        public string Name => $"Route Cipher ({_direction}, {_rows}x{_cols})";
        public CipherType Type => CipherType.Transposition;

        public enum RouteDirection
        {
            Spiral,
            Zigzag
        }

        public RouteCipher(int rows, int cols, RouteDirection direction)
        {
            if (rows < 2 || cols < 2)
                throw new ArgumentException("Rows and columns must be at least 2");

            _rows = rows;
            _cols = cols;
            _direction = direction;
        }

        public string Encrypt(string plaintext)
        {
            if (string.IsNullOrEmpty(plaintext))
                return plaintext;

            // Create and fill the matrix
            char[,] matrix = new char[_rows, _cols];
            int charIndex = 0;

            // Fill the matrix row by row
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (charIndex < plaintext.Length)
                    {
                        matrix[i, j] = plaintext[charIndex++];
                    }
                    else
                    {
                        matrix[i, j] = 'X'; // Padding
                    }
                }
            }

            // Read the matrix according to the route
            StringBuilder result = new StringBuilder();

            if (_direction == RouteDirection.Spiral)
            {
                // Spiral route (clockwise from outside to inside)
                int top = 0, bottom = _rows - 1, left = 0, right = _cols - 1;

                while (top <= bottom && left <= right)
                {
                    // Move right
                    for (int i = left; i <= right; i++)
                        result.Append(matrix[top, i]);
                    top++;

                    // Move down
                    for (int i = top; i <= bottom; i++)
                        result.Append(matrix[i, right]);
                    right--;

                    // Move left
                    if (top <= bottom)
                    {
                        for (int i = right; i >= left; i--)
                            result.Append(matrix[bottom, i]);
                        bottom--;
                    }

                    // Move up
                    if (left <= right)
                    {
                        for (int i = bottom; i >= top; i--)
                            result.Append(matrix[i, left]);
                        left++;
                    }
                }
            }
            else // Zigzag
            {
                // Read in zigzag pattern (alternating direction for each row)
                for (int i = 0; i < _rows; i++)
                {
                    if (i % 2 == 0)
                    {
                        // Left to right
                        for (int j = 0; j < _cols; j++)
                            result.Append(matrix[i, j]);
                    }
                    else
                    {
                        // Right to left
                        for (int j = _cols - 1; j >= 0; j--)
                            result.Append(matrix[i, j]);
                    }
                }
            }

            return result.ToString();
        }

        public string Decrypt(string ciphertext)
        {
            if (string.IsNullOrEmpty(ciphertext))
                return ciphertext;

            // Create the matrix
            char[,] matrix = new char[_rows, _cols];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    matrix[i, j] = '\0';
                }
            }

            int charIndex = 0;

            // Fill the matrix according to the route
            if (_direction == RouteDirection.Spiral)
            {
                // Spiral route (clockwise from outside to inside)
                int top = 0, bottom = _rows - 1, left = 0, right = _cols - 1;

                while (top <= bottom && left <= right && charIndex < ciphertext.Length)
                {
                    // Move right
                    for (int i = left; i <= right && charIndex < ciphertext.Length; i++)
                        matrix[top, i] = ciphertext[charIndex++];
                    top++;

                    // Move down
                    for (int i = top; i <= bottom && charIndex < ciphertext.Length; i++)
                        matrix[i, right] = ciphertext[charIndex++];
                    right--;

                    // Move left
                    if (top <= bottom)
                    {
                        for (int i = right; i >= left && charIndex < ciphertext.Length; i--)
                            matrix[bottom, i] = ciphertext[charIndex++];
                        bottom--;
                    }

                    // Move up
                    if (left <= right)
                    {
                        for (int i = bottom; i >= top && charIndex < ciphertext.Length; i--)
                            matrix[i, left] = ciphertext[charIndex++];
                        left++;
                    }
                }
            }
            else // Zigzag
            {
                // Fill in zigzag pattern
                for (int i = 0; i < _rows && charIndex < ciphertext.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        // Left to right
                        for (int j = 0; j < _cols && charIndex < ciphertext.Length; j++)
                            matrix[i, j] = ciphertext[charIndex++];
                    }
                    else
                    {
                        // Right to left
                        for (int j = _cols - 1; j >= 0 && charIndex < ciphertext.Length; j--)
                            matrix[i, j] = ciphertext[charIndex++];
                    }
                }
            }

            // Read the matrix row by row
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (matrix[i, j] != '\0' && matrix[i, j] != 'X')
                        result.Append(matrix[i, j]);
                }
            }

            return result.ToString();
        }
    }
}