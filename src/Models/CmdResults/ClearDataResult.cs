namespace Simulator.Models.CmdResults
{
    public static class ClearDataResult
    {
        /// <summary>
        /// 设备处于工作状态
        /// </summary>
        public static byte[] Working { get; set; } = { 0x01 };

        /// <summary>
        /// 低电压
        /// </summary>
        public static byte[] LowVoltage { get; set; } = { 0x0a };
    }
}
