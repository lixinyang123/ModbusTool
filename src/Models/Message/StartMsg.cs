using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    public class StartMsg : BaseMsg
    {
        public StartMsg(byte[] cmdCode, StartResult result) : 
            base(0x04, cmdCode, Convert.ToByte(result)) { }

        /// <summary>
        /// 读取完整消息
        /// </summary>
        /// <returns>消息buffer</returns>
        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            return buffer.ToArray();
        }
    }
}
