namespace Simulator.Models
{
    public static class Version
    {
        /// <summary>
        /// 硬件版本号
        /// </summary>
        public static byte[] HwVersion { get; set; } = { 0x00, 0x00, 0x01, 0x00 };

        /// <summary>
        /// 软件版本号
        /// </summary>
        public static byte[] SwVersion { get; set; } = { 0x00, 0x00, 0x01, 0x00 };
    }
}
