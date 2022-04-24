namespace Simulator.Models.CmdResults
{
    public static class StartResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        public static byte Success { get; set; } = 0x00;

        /// <summary>
        /// 列表错误
        /// </summary>
        public static byte ListError { get; set; } = 0x01;

        /// <summary>
        /// 时间戳错误
        /// </summary>
        public static byte TimestampError { get; set; } = 0x02;

        /// <summary>
        /// 电压低
        /// </summary>
        public static byte LowVoltage { get; set; } = 0x0a;
    }
}
