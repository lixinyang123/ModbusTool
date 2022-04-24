namespace Simulator.Models.Message
{
    public class ReadVersionMsg
    {
        public byte[] CmdCode { get; }

        public byte[] Result { get; }

        public byte[] HwVersion { get; }

        public byte[] SwVersion { get; }

        public byte Length
        {
            get
            {
                int length = 1 + CmdCode.Length + Result.Length + HwVersion.Length + SwVersion.Length;
                return Convert.ToByte(length);
            }
        }

        public ReadVersionMsg(byte[] cmdCode, byte[] result, byte[] hwVersion, byte[] swVersion)
        {
            CmdCode = cmdCode;
            Result = result;
            HwVersion = hwVersion;
            SwVersion = swVersion;
        }

        public byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };

            buffer.AddRange(CmdCode);
            buffer.AddRange(Result);
            buffer.AddRange(HwVersion);
            buffer.AddRange(SwVersion);

            return buffer.ToArray();
        }
    }
}
