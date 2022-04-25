using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class ClearDataHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new ClearDataMsg(Models.CmdResults.ClearDataResult.Working).GetBytes();
    }
}
