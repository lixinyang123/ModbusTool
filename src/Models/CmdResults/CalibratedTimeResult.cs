namespace Simulator.Models.CmdResults
{
    public static class CalibratedTimeResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        public static byte[] Success { get; set; } = { 0x00 };

        /// <summary>
        /// 时间戳错误（Stamp 数过小）
        /// </summary>
        public static byte[] TimestampError { get; set; } = { 0x02 };
    }
}
