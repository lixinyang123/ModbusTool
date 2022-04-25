using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    public class GetTimeMsg : BaseMsg<GetTimeResult>
    {
        public int Time { get; }

        public GetTimeMsg(GetTimeResult result, int time) : base(0x08, CommandCode.GetTime, result)
        {
            Time = time;
        }

        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);

            byte[] timeBuffer = BitConverter.GetBytes(Time).Reverse().ToArray();

            buffer.AddRange(timeBuffer);
            return buffer.ToArray();
        }
    }
}
 