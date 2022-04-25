using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class SetCalibrationHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new SetCalibrationMsg(Models.CmdResults.SetCalibrationResult.Success).GetBytes();
    }
}
