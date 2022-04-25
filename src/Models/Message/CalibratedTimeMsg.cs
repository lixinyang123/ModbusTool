using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    public class CalibratedTimeMsg : BaseMsg<CalibratedTimeResult>
    {
        public CalibratedTimeMsg(CalibratedTimeResult result) : base(0x04, CommandCode.CalibratedTime, result) { }

        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            return buffer.ToArray();
        }
    }
}
