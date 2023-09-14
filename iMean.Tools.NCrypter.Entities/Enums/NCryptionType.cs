namespace iMean.Tools.NCrypter.Entities.Enums
{
    public class NCryptionType : Enumeration
    {
        public static NCryptionType NCrypt = new(0, nameof(NCrypt));
        public static NCryptionType DCrypt = new(1, nameof(DCrypt));

        NCryptionType(int id, string value) : base(id, value) { }
    }
}
