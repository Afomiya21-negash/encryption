namespace ClassicalCiphers.Interfaces
{
    public interface InCipher
    {
        string Encrypt(string plaintext);
        string Decrypt(string ciphertext);
        string Name { get; }
        CipherType Type { get; }
    }

    public enum CipherType
    {
        Substitution,
        Transposition
    }
}