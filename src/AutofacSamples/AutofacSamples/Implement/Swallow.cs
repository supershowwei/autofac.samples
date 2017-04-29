using AutofacSamples.Protocol;

namespace AutofacSamples.Implement
{
    public class Swallow : IFlying
    {
        public string Fly()
        {
            return "Swallow is flying.";
        }
    }
}