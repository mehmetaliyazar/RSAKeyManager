using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace RSAKeyManager
{
    public class KeyClass
    {
        public RSACryptoServiceProvider RSAKey;
        public RSAParameters _privateKey;
        public RSAParameters _publicKey;
        public int _KeySize = 0;
        public string _KeyType = "";

        public void GenerateKey(int keysize)
        {
            RSAKey = new RSACryptoServiceProvider(keysize);
            //RSAKey.PersistKeyInCsp = false;
            _publicKey = RSAKey.ExportParameters(false);
            _privateKey = RSAKey.ExportParameters(true);
            _KeySize = RSAKey.KeySize;
            _KeyType = CheckType(RSAKey);
        }

        public string CheckType(RSACryptoServiceProvider csp)
        {
            if (csp.PublicOnly) { return "Public"; }
            else { return "Private"; }
        }

        public void ImportKey(string path)
        {
            RSAKey = new RSACryptoServiceProvider();
            RSAKey.FromXmlString(File.ReadAllText(path));
            if (RSAKey.PublicOnly) { _KeyType = "Public"; }
            else { _KeyType = "Private"; _publicKey = RSAKey.ExportParameters(true); }
            _publicKey = RSAKey.ExportParameters(false);
            _KeySize = RSAKey.KeySize;
            //AlgorithmIdentifier learn
        }

        public string EncryptData(string textToEncrypt)
        {
            var data = Encoding.UTF8.GetBytes(textToEncrypt);
            return Convert.ToBase64String(RSAKey.Encrypt(data, false));
        }

        public string DecryptData(string textToDecrypt)
        {
            var data = Convert.FromBase64String(textToDecrypt);
            return Encoding.UTF8.GetString(RSAKey.Decrypt(data, false));
        }
    }
}
