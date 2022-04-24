namespace Simulator.Models.Message
{
    public class ReadVersionMsg
    {
        public byte CmdCode { get; }

        public byte Result { get; }

        public byte HwVersion { get; }

        public byte SwVersion { get; }

        public byte Length
        {
            get => Convert.ToByte(GetType().GetProperties().Length);
        }

        public ReadVersionMsg(byte cmdCode, byte result, byte hwVersion, byte swVersion)
        {
            CmdCode = cmdCode;
            Result = result;
            HwVersion = hwVersion;
            SwVersion = swVersion;
        }

        public byte[] GetBytes()
        {
            return new List<byte>()
            {
                Length,
                CmdCode,
                Result,
                HwVersion,
                SwVersion
            }.ToArray();
        }
    }
}
