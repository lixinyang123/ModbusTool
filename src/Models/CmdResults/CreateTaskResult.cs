namespace Simulator.Models.CmdResults
{
    public static class CreateTaskResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        public static byte[] Success { get; set; } = { 0x00 };

        /// <summary>
        /// 段位号过大
        /// </summary>
        public static byte[] SegmentNumError { get; set; } = { 0x01 };

        /// <summary>
        /// 时间戳错误（时间戳先后错误）
        /// </summary>
        public static byte[] TimestampError { get; set; } = { 0x02 };

        /// <summary>
        /// 单段错误（单段过长 5天  过短 3秒）
        /// </summary>
        public static byte[] SegmentError { get; set; } = { 0x03 };

        /// <summary>
        /// 频率错误
        /// </summary>
        public static byte[] FrequencyError { get; set; } = { 0x04 };

        /// <summary>
        /// 采样间隔错误
        /// </summary>
        public static byte[] IntervalError { get; set; } = { 0x05 };
    }
}
