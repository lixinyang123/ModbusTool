namespace Simulator.Models.CmdResults
{
    public static class GetTimeResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        public static byte[] Success { get; set; } = { 0x00 };

        /// <summary>
        /// 未校准
        /// </summary>
        public static byte[] UnCalibrated { get; set; } = { 0x01 };
    }
}
