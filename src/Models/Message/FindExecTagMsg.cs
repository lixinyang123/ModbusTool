using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    /// <summary>
    /// 是否是清空记录
    /// </summary>
    enum Clear
    {
        No = 0x00,
        Yes = 0x01
    }

    internal class FindExecTagMsg : BaseMsg<FindExecTagResult>
    {
        public byte Clear { get; }

        public byte[] Cmd { get; }

        public FindExecTagMsg(FindExecTagResult result,
            Clear clear,
            short cmd)
            : base(0x07, CommandCode.FindExecTag, result)
        {
            Clear = Convert.ToByte(clear);
            Cmd = BitConverter.GetBytes(cmd);
        }

        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            buffer.Add(Clear);
            buffer.AddRange(Cmd);
            return buffer.ToArray();
        }
    }
}
