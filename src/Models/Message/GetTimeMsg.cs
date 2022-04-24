using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    public class GetTimeMsg : BaseMsg<GetTimeResult>
    {
        public GetTimeMsg(byte[] cmdCode, GetTimeResult result) : base(0x08, cmdCode, result) { }

        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            buffer.Add(Convert.ToByte(DateTime.UtcNow));
            return buffer.ToArray();
        }
    }
}
