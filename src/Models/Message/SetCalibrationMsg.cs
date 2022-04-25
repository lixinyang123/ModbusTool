using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    internal class SetCalibrationMsg : BaseMsg<SetCalibrationResult>
    {
        public SetCalibrationMsg(SetCalibrationResult result) : base(0x04, CommandCode.SetCalibration, result) { }

        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            return buffer.ToArray();
        }
    }
}
