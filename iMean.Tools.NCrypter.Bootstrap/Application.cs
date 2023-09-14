using Autofac;

namespace iMean.Tools.NCrypter.Bootstrap
{
    public abstract class Application : IApplication
    {
        protected Application() 
        {
            ContainerBuilder = new ContainerBuilder();
        }

        public IContainer Container { get; private set; }

        public ContainerBuilder ContainerBuilder { get; }

        public virtual void Run()
        {
            RegisterTypes();
            Build();
        }

        protected void Build()
        {
            Container = ContainerBuilder.Build();
        }

        protected abstract void RegisterTypes();
    }
}
