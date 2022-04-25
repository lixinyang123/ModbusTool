using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class StopHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new StopMsg(Models.CmdResults.StopResult.Success).GetBytes();
    }
}
