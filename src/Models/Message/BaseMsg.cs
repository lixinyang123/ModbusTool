namespace Simulator.Models.Message
{
    public abstract class BaseMsg<T>
    {
        /// <summary>
        /// 消息长度
        /// </summary>
        public byte Length { get; }

        /// <summary>
        /// 命令码 CommandCode
        /// </summary>
        public byte[] CmdCode { get; }

        /// <summary>
        /// 结果
        /// </summary>
        public byte Result { get; }

        public BaseMsg(byte length, byte[] cmdCode, T result)
        {
            Length = length;
            CmdCode = cmdCode;
            Result = Convert.ToByte(result);
        }

        public abstract byte[] GetBytes();
    }
}
