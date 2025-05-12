using System.Collections.Generic;

namespace ClassicalCiphers.Utilities
{
    public static class CipherUtils
    {
        private static readonly Dictionary<string, string> CipherDescriptions = new Dictionary<string, string>
        {
            { "CaesarCipher", "Shifts each letter in the plaintext by a fixed number of positions in the alphabet." },
            { "VigenereCipher", "Uses a keyword to determine variable shifts for each letter in the plaintext." },
            { "MonoalphabeticCipher", "Substitutes each letter in the plaintext with another letter according to a fixed mapping." },
            { "ColumnarTranspositionCipher", "Arranges the plaintext in a grid and reads it column by column according to a key." },
            { "RailFenceCipher", "Writes the plaintext in a zigzag pattern across multiple 'rails' and reads off by rows." },
            { "RouteCipher", "Arranges the plaintext in a grid and reads it following a specific route pattern." }
        };

        public static string GetCipherDescription(string cipherName)
        {
            if (CipherDescriptions.TryGetValue(cipherName, out string description))
            {
                return description;
            }

            return "No description available.";
        }
    }
}