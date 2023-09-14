using System.Security.Cryptography;

namespace iMean.Tools.NCrypter.Business
{
    public class AES256NCryptR : INCryptR
    {
        private const int KeySize = 256;
        private const int IVSize = KeySize / 8;

        private readonly IKeyFileManager _keyFileManager;
        private readonly string _keyFilepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "key.ncrypt");
        private readonly byte[] _key;
        
        private byte[] _iv;

        public AES256NCryptR(IKeyFileManager keyFileManager) 
        {
            _keyFileManager = keyFileManager ?? throw new ArgumentNullException(nameof(keyFileManager));
            _iv = new byte[IVSize];

            if (!File.Exists(_keyFilepath))
            {
                _key = GenerateDefaultKey();
                _keyFileManager.SaveKeyTo(_key, _keyFilepath);
            }
            else
            {
                _key = _keyFileManager.LoadKeyFrom(_keyFilepath);
            }
        }

        public string NCrypt(string inputText)
        {
            using (Aes aes = Aes.Create()) 
            {
                aes.KeySize = KeySize;
                aes.Key = _key;
                aes.GenerateIV();

                _iv = aes.IV;

                byte[] cyphertext;
                using (var encryptor = aes.CreateEncryptor())
                {
                    byte[] input = Convert.FromBase64String(inputText);
                    cyphertext = encryptor.TransformFinalBlock(input, 0, input.Length);
                }

                return Convert.ToBase64String(cyphertext);
            }
        }
        
        public string DCrypt(string cypherText)
        {
            var cypher = Convert.FromBase64String(cypherText);

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = KeySize;
                aes.Key = _key;
                aes.IV = _iv;

                byte[] decryptedText;
                using (var decryptor = aes.CreateDecryptor())
                {
                    decryptedText = decryptor.TransformFinalBlock(cypher, 0, cypher.Length);
                    return Convert.ToBase64String(decryptedText);
                }
            }
        }

        private byte[] GenerateDefaultKey()
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = KeySize;
                aes.GenerateKey();

                return aes.Key;
            }
        }
    }
}
