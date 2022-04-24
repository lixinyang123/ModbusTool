namespace Simulator.Models.CmdResults
{
    public enum StartResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 0x00,

        /// <summary>
        /// 列表错误
        /// </summary>
        ListError = 0x01,

        /// <summary>
        /// 时间戳错误
        /// </summary>
        TimestampError = 0x02,

        /// <summary>
        /// 电压低
        /// </summary>
        LowVoltage = 0x0a
    }
}
