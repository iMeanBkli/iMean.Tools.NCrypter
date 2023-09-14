namespace iMean.Tools.NCrypter.Entities
{
    public class UserInput
    {
        public UserInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }

            Value = input;
        }

        public string Value { get; }
    }
}
