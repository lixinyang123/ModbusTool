using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    internal class ClearTaskMsg : BaseMsg<ClearTaskResult>
    {
        public ClearTaskMsg(ClearTaskResult result) : base(0x04, CommandCode.ClearTask, result) { }

        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            return buffer.ToArray();
        }
    }
}
