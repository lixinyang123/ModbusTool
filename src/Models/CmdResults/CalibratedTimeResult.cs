namespace Simulator.Models.CmdResults
{
    public enum CalibratedTimeResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 0x00,

        /// <summary>
        /// 时间戳错误（Stamp 数过小）
        /// </summary>
        TimestampError = 0x01
    }
}
