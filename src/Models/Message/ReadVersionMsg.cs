namespace Simulator.Models.Message
{
    public class ReadVersionMsg: BaseMsg
    {
        /// <summary>
        /// 硬件版本 Version
        /// </summary>
        public byte HwVersion { get; }

        /// <summary>
        /// 软件版本 Version
        /// </summary>
        public byte SwVersion { get; }

        /// <summary>
        /// 消息长度
        /// </summary>
        public byte Length { get; } = 0x0c;

        public ReadVersionMsg(byte[] cmdCode, byte result, byte hwVersion, byte swVersion) : base(cmdCode, result)
        {
            HwVersion = hwVersion;
            SwVersion = swVersion;
        }

        /// <summary>
        /// 读取完整消息
        /// </summary>
        /// <returns>消息buffer</returns>
        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            buffer.Add(HwVersion);
            buffer.Add(SwVersion);
            return buffer.ToArray();
        }
    }
}
