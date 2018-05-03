using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Hovmand.Model.App
{
    public class PasswordHash
    {
        private SHA1CryptoServiceProvider _sha1Provider = new SHA1CryptoServiceProvider(); //Ny service til at hashe

        public string HashString(string input) //Returnerer hash fra string
        {
            var inputBytes = Encoding.ASCII.GetBytes(input); //Starter med at lave input string om til bytes, da du ikke kan hashe strings, men derimod bytes
            var inputHashed = _sha1Provider.ComputeHash(inputBytes); //Laver det egentlige hash fra bytes
            var outputHashed = BitConverter.ToString(inputHashed).Replace("-","").ToLower(); //Laver det tilbage om til en string så det er læseligt
            return outputHashed; //Returnerer den endelige string
        }

        public bool MatchString(string input, List<string> toMatchList) //Sammenligner 1 string med en liste, hvor den hasher input
        {
            var inputHashed = HashString(input); //Bruger HashString metoden til at hashe

            foreach (var hash in toMatchList)
            {
                if (inputHashed == hash) //Hvis de 2 matcher
                {
                    return true;
                }
            }

            return false;
        }
    }
}