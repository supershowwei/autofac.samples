using Autofac;
using Autofac.Extras.DynamicProxy;
using AutofacSamples.Implement;
using AutofacSamples.Interceptors;
using AutofacSamples.Protocol;

namespace AutofacSamples
{
    public class AutofacConfig
    {
        public static readonly AutofacConfig Instance = new AutofacConfig();

        private AutofacConfig()
        {
        }

        public IContainer Container { get; private set; }

        public void Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<HelmetInterceptor>();
            builder.RegisterType<VirtualRealityInterceptor>();

            builder.RegisterType<Swallow>().Named<IFlying>(nameof(Swallow)).EnableInterfaceInterceptors();
            builder.RegisterType<Ostrich>().Named<IFlying>(nameof(Ostrich)).EnableInterfaceInterceptors();
            builder.RegisterType<Dog>().EnableClassInterceptors();

            this.Container = builder.Build();
        }
    }
}