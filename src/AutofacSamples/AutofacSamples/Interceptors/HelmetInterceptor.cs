using Castle.DynamicProxy;

namespace AutofacSamples.Interceptors
{
    public class HelmetInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();

            invocation.ReturnValue += " wear helmet";
        }
    }
}