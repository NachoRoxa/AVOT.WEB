using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AVOT.NEGOCIO
{
    public sealed class Criptografo
    {

        private const int SaltSize = 16;
        private const int HashSize = 20;

        public Criptografo() { }

        public string Hash(string password, int iteraciones)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iteraciones);
            var hash = pbkdf2.GetBytes(HashSize);

            var hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);
            var base64Hash = Convert.ToBase64String(hashBytes);
            return string.Format("$MIHASH$V1${0}${1}", iteraciones, base64Hash);
        }
        /// <summary>
        /// Hash con 10000 iteraciones
        public string Hash(string password)
        {
            return Hash(password, 10000);
        }

        public bool soportaHash(string hashString)
        {
            return hashString.Contains("$MIHASH$V1$");
        }


        public bool Verificar(string password, string hashedPassword)
        {

            if (!soportaHash(hashedPassword))
            {
                throw new NotSupportedException("No soporta este tipo de hash");
            }

            var splittedHashString = hashedPassword.Replace("$MIHASH$V1$", "").Split('$');
            var iteraciones = int.Parse(splittedHashString[0]);
            var base64Hash = splittedHashString[1];
            var hashBytes = Convert.FromBase64String(base64Hash);
            var salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iteraciones);
            byte[] hash = pbkdf2.GetBytes(HashSize);


            for (var i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
