using Autofac.Extras.DynamicProxy;
using AutofacSamples.Interceptors;
using AutofacSamples.Protocol;

namespace AutofacSamples.Implement
{
    [Intercept(typeof(VirtualRealityInterceptor))]
    public class Ostrich : IFlying
    {
        public string Fly()
        {
            return "Ostrich is flying.";
        }
    }
}