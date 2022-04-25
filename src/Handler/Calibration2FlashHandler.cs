using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class Calibration2FlashHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new Calibration2FlashMsg(Models.CmdResults.Calibration2FlashResult.Success).GetBytes();
    }
}
