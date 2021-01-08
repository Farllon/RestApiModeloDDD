using Autofac;

namespace RestApiModeloDDD.Infrastructure.Crosscutting.IOC
{
    public class IOCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            IOCConfiguration.Load(builder);
        }
    }
}