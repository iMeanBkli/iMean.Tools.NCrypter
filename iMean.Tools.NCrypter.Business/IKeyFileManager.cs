namespace iMean.Tools.NCrypter.Business
{
    public interface IKeyFileManager
    {
        byte[] LoadKeyFrom(string keyFilepath);
        void SaveKeyTo(byte[] key, string keyFilepath);
    }
}
