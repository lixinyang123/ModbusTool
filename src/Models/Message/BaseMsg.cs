namespace Simulator.Models.Message
{
    public abstract class BaseMsg
    {
        /// <summary>
        /// 命令码 CommandCode
        /// </summary>
        public byte[] CmdCode { get; }

        /// <summary>
        /// 结果 VersionResult
        /// </summary>
        public byte Result { get; }

        public BaseMsg(byte[] cmdCode, byte result)
        {
            CmdCode = cmdCode;
            Result = result;
        }

        public abstract byte[] GetBytes();
    }
}
