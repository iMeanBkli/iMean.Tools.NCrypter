namespace iMean.Tools.NCrypter.WinForms
{
    using Autofac;
    using iMean.Tools.NCrypter.Business;
    using BootstrapApplication = Bootstrap.Application;
    public class WinFormsApplication : BootstrapApplication
    {
        private readonly Form _mainForm;

        public WinFormsApplication(Form mainForm)
        {
            _mainForm = mainForm ?? throw new ArgumentNullException(nameof(MainForm));
        }

        public override void Run()
        {
            base.Run();

            _mainForm.Show();
        }

        protected override void RegisterTypes()
        {
            ContainerBuilder.RegisterType<KeyFileManager>().As<IKeyFileManager>();
            ContainerBuilder.RegisterType<AES256NCryptR>().As<INCryptR>();
        }
    }
}
