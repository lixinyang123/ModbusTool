using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    public class ClearDataMsg : BaseMsg
    {
        public ClearDataMsg(byte[] cmdCode, ClearDataResult result) : base(0x00, cmdCode, Convert.ToByte(result)) { }

        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            return buffer.ToArray();
        }
    }
}
