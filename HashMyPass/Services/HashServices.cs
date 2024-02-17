using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace HashMyPass.Services
{
    public interface IHashServices
    {
        string Md5(string input);
        string Sha1(string input);
        string Sha256(string input);
        string Sha384(string input);
        string Sha512(string input);
        string Base64(string input);
    }

    public class HashServices : IHashServices   
    {
        [SuppressMessage("Interoperability", "CA1416:Validate platform compatibility")]
        public string Md5(string input)
        {
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hashBytes = System.Security.Cryptography.MD5.HashData(inputBytes);
            var sb = new StringBuilder();
            foreach (var t in hashBytes)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
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