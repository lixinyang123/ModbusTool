using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class ClearTaskHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new ClearTaskMsg(Models.CmdResults.ClearTaskResult.Success).GetBytes();
    }
}
