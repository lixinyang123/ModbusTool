using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class GetCalibrationHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new GetCalibrationMsg(Models.CmdResults.GetCalibrationResult.Success, 10, 0, 2, 3).GetBytes();
    }
}
