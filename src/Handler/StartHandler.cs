using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class StartHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new StartMsg(Models.CmdResults.StartResult.Success).GetBytes();
    }
}
