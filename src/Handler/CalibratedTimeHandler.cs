using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class CalibratedTimeHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new CalibratedTimeMsg(Models.CmdResults.CalibratedTimeResult.Success).GetBytes();
    }
}
