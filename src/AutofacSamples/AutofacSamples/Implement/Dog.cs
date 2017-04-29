using Autofac.Extras.DynamicProxy;
using AutofacSamples.Interceptors;

namespace AutofacSamples.Implement
{
    [Intercept(typeof(HelmetInterceptor))]
    public class Dog
    {
        public virtual string Walk()
        {
            return "Dog is walking.";
        }
    }
}