namespace Simulator.Models.CmdResults
{
    public enum CreateTaskResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 0x00,

        /// <summary>
        /// 段位号过大
        /// </summary>
        SegmentNumError = 0x01,

        /// <summary>
        /// 时间戳错误（时间戳先后错误）
        /// </summary>
        TimestampError = 0x02,

        /// <summary>
        /// 单段错误（单段过长 5天  过短 3秒）
        /// </summary>
        SegmentError = 0x03,

        /// <summary>
        /// 频率错误
        /// </summary>
        FrequencyError = 0x04,

        /// <summary>
        /// 采样间隔错误
        /// </summary>
        IntervalError = 0x05
    }
}
