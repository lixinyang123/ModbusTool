namespace Simulator.Handler
{
    internal interface IHandler
    {
        public byte[] Handle(byte[] msg);
    }
}
