namespace Simulator.Models.CmdResults
{
    public static class GetCalibrationResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        public static byte Success { get; set; } = 0x00;

        /// <summary>
        /// 校准表错误
        /// </summary>
        public static byte CalibratedError { get; set; } = 0x01;

        /// <summary>
        /// ID 错误
        /// </summary>
        public static byte IDError { get; set; } = 0x02;
    }
}
