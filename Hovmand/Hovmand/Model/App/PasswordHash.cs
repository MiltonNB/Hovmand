using System.Security.Cryptography;
using System.Text;

namespace Hovmand.Model.App
{
    public class PasswordHash
    {
        private SHA1CryptoServiceProvider _sha1Provider = new SHA1CryptoServiceProvider();

        public string HashString(string input)
        {
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var inputHashed = _sha1Provider.ComputeHash(inputBytes);
            var outputHashed = Encoding.ASCII.GetString(inputHashed);
            return outputHashed;
        }

        public bool MatchString(string input, string toMatch)
        {
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var inputHashed = _sha1Provider.ComputeHash(inputBytes);
            var inputHashedString = Encoding.ASCII.GetString(inputHashed);

            if (inputHashedString == toMatch)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}