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

            int time = Convert.ToInt32(DateTimeOffset.Now.ToUnixTimeSeconds());
            byte[] timeBuffer = BitConverter.GetBytes(time).Reverse().ToArray();

            buffer.AddRange(timeBuffer);
            return buffer.ToArray();
        }
    }
}
 