using Castle.DynamicProxy;

namespace AutofacSamples.Interceptors
{
    public class VirtualRealityInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();

            invocation.ReturnValue += " wear VR";
        }
    }
}