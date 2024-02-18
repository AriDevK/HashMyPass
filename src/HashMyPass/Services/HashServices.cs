using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace HashMyPass.Services
{
    public enum HashAlgorithm
    {
        Sha1,
        Sha256,
        Sha384,
        Sha512,
        Base64
    }
    
    public interface IHashServices
    {
        string? Encrypt(string input, HashAlgorithm algorithm);
        string Sha1(string input);
        string Sha256(string input);
        string Sha384(string input);
        string Sha512(string input);
        string Base64(string input);
    }

    public class HashServices : IHashServices   
    {
        public string? Encrypt(string input, HashAlgorithm algorithm)
        {
            return algorithm switch
            {
                HashAlgorithm.Sha1 => Sha1(input),
                HashAlgorithm.Sha256 => Sha256(input),
                HashAlgorithm.Sha384 => Sha384(input),
                HashAlgorithm.Sha512 => Sha512(input),
                HashAlgorithm.Base64 => Base64(input),
                _ => null
            };
        }

        public string Sha1(string input)
        {
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hashBytes = System.Security.Cryptography.SHA1.HashData(inputBytes);
            var sb = new StringBuilder();
            foreach (var t in hashBytes)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }

        public string Sha256(string input)
        {
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hashBytes = System.Security.Cryptography.SHA256.HashData(inputBytes);
            var sb = new StringBuilder();
            foreach (var t in hashBytes)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }

        public string Sha384(string input)
        {
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hashBytes = System.Security.Cryptography.SHA384.HashData(inputBytes);
            var sb = new StringBuilder();
            foreach (var t in hashBytes)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }

        public string Sha512(string input)
        {
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hashBytes = System.Security.Cryptography.SHA512.HashData(inputBytes);
            var sb = new StringBuilder();
            foreach (var t in hashBytes)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }

        public string Base64(string input)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}