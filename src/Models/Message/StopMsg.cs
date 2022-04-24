namespace Simulator.Models.Message
{
    public class StopMsg : BaseMsg
    {
        /// <summary>
        /// 消息长度
        /// </summary>
        public byte Length { get; } = 0x04;

        public StopMsg(byte[] cmdCode, byte result) : base(cmdCode, result) { }

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
