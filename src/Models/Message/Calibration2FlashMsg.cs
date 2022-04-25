using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    internal class Calibration2FlashMsg : BaseMsg<Calibration2FlashResult>
    {
        public Calibration2FlashMsg(Calibration2FlashResult result) : base(0x04, CommandCode.Calibration2Flash, result) { }

        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            return buffer.ToArray();
        }
    }
}
