namespace iMean.Tools.NCrypter.Business
{
    public class KeyFileManager : IKeyFileManager
    {
        public byte[] LoadKeyFrom(string keyFilepath)
        {
            if (string.IsNullOrWhiteSpace(keyFilepath))
            {
                throw new ArgumentNullException(nameof(keyFilepath));
            }

            if (!File.Exists(keyFilepath))
            {
                throw new FileNotFoundException(nameof(keyFilepath));
            }

            return File.ReadAllBytes(keyFilepath);
        }

        public void SaveKeyTo(byte[] key, string keyFilepath)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (string.IsNullOrWhiteSpace(keyFilepath))
            {
                throw new ArgumentNullException(nameof(keyFilepath));
            }

            File.WriteAllBytes(keyFilepath, key);
        }
    }
}
