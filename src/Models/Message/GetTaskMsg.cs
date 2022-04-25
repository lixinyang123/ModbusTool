using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    internal class GetTaskMsg : BaseMsg<GetTaskResult>
    {
        public byte SegId { get; }

        public byte[] StartStamp { get; }

        public byte[] EndStamp { get; }

        public byte SpFre { get; }

        public byte SpMode { get; }

        public byte SpInterval { get; }

        public byte[] MaxSampleNum { get; }

        public GetTaskMsg(GetTaskResult result,
            int segId,
            int startStamp,
            int endStamp,
            int spMode,
            int spFre,
            int spInterval,
            int maxSampleNum) :
            base(0x0e, CommandCode.GetTask, result)
        {
            SegId = Convert.ToByte(segId);
            StartStamp = BitConverter.GetBytes(startStamp).Reverse().ToArray();
            EndStamp = BitConverter.GetBytes(endStamp).Reverse().ToArray();
            SpMode = Convert.ToByte(spMode);
            SpFre = Convert.ToByte(spFre);
            SpInterval = Convert.ToByte(spInterval);
            MaxSampleNum = BitConverter.GetBytes(maxSampleNum).Reverse().ToArray();
        }


        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            buffer.Add(SegId);
            buffer.AddRange(StartStamp);
            buffer.AddRange(EndStamp);
            buffer.Add(SpMode);
            buffer.Add(SpFre);
            buffer.Add(SpInterval);
            buffer.AddRange(MaxSampleNum);
            return buffer.ToArray();
        }
    }
}
