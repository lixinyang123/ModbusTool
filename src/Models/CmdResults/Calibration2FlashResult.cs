namespace Simulator.Models.CmdResults
{
    public static class Calibration2FlashResult
    {
        /// <summary>
        /// Vmcu 错误
        /// </summary>
        public static byte[] VmcuError { get; set; } = { 0x00 };

        /// <summary>
        /// Vout错误（单调性错误）
        /// </summary>
        public static byte[] VoutError { get; set; } = { 0x01 };
    }
}
