using Autofac;

namespace iMean.Tools.NCrypter.Bootstrap
{
    public interface IApplication
    {
        IContainer Container { get; }
        ContainerBuilder ContainerBuilder { get; }
    }
}
