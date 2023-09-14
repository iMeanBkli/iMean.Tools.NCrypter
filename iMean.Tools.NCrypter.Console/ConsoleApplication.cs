using Autofac;
using iMean.Tools.NCrypter.Bootstrap;
using iMean.Tools.NCrypter.Business;

namespace iMean.Tools.NCrypter.Console
{
    using SystemConsole = System.Console;

    public class ConsoleApplication : Application
    {
        public ConsoleApplication() 
            : base() 
        { 
        }

        public override void Run()
        {
            base.Run();
            using (var scope = Container.BeginLifetimeScope())
            {
                var nCryptR = scope.Resolve<INCryptR>();
                var userInput = string.Empty;

                do
                {
                    SystemConsole.WriteLine("Input (press Enter to validate): ");

                    userInput = SystemConsole.ReadLine();

                    if (string.IsNullOrEmpty(userInput))
                    {
                        SystemConsole.WriteLine("Input must not be null or empty string.");
                    }
                }
                while (string.IsNullOrEmpty(userInput));

                var cypherText = nCryptR.NCrypt(userInput);

                SystemConsole.WriteLine($"NCrypted text : {cypherText}");

                var decryptedText = nCryptR.DCrypt(cypherText);

                SystemConsole.WriteLine($"DCrypted text : {decryptedText}");
            }
        }

        protected override void RegisterTypes()
        {
            ContainerBuilder.RegisterType<KeyFileManager>().As<IKeyFileManager>();
            ContainerBuilder.RegisterType<AES256NCryptR>().As<INCryptR>();
        }
    }
}
