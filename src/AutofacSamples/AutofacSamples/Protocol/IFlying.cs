using Autofac.Extras.DynamicProxy;
using AutofacSamples.Interceptors;

namespace AutofacSamples.Protocol
{
    [Intercept(typeof(HelmetInterceptor))]
    public interface IFlying
    {
        string Fly();
    }
}