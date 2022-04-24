namespace Simulator.Models.Message
{
    public class ReadVersionMsg
    {
        public byte[] CmdCode { get; }

        public byte Result { get; }

        public byte HwVersion { get; }

        public byte SwVersion { get; }

        public byte Length { get; } = 0x0c;

        public ReadVersionMsg(byte[] cmdCode, byte result, byte hwVersion, byte swVersion)
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
            buffer.Add(HwVersion);
            buffer.Add(SwVersion);
            return buffer.ToArray();
        }
    }
}
