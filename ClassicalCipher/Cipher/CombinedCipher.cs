using System;
using ClassicalCiphers.Interfaces;

namespace ClassicalCiphers.Ciphers
{
    public class CombinedCipher : InCipher
    {
        private readonly InCipher _substitutionCipher;
        private readonly InCipher _transpositionCipher;
        public string Name => $"{_substitutionCipher.Name} + {_transpositionCipher.Name}";
        public CipherType Type => CipherType.Substitution; // Not used for combined

        public CombinedCipher(InCipher substitutionCipher, InCipher transpositionCipher)
        {
            _substitutionCipher = substitutionCipher ?? throw new ArgumentNullException(nameof(substitutionCipher));
            _transpositionCipher = transpositionCipher ?? throw new ArgumentNullException(nameof(transpositionCipher));

            if (substitutionCipher.Type != CipherType.Substitution)
                throw new ArgumentException("First cipher must be a substitution cipher");

            if (transpositionCipher.Type != CipherType.Transposition)
                throw new ArgumentException("Second cipher must be a transposition cipher");
        }

        public string Encrypt(string plaintext)
        {
            // First apply substitution, then transposition
            string substituted = _substitutionCipher.Encrypt(plaintext);
            return _transpositionCipher.Encrypt(substituted);
        }

        public string Decrypt(string ciphertext)
        {
            // First undo transposition, then substitution
            string transposed = _transpositionCipher.Decrypt(ciphertext);
            return _substitutionCipher.Decrypt(transposed);
        }
    }
}