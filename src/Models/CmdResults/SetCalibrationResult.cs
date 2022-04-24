namespace Simulator.Models.CmdResults
{
    public class SetCalibrationResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        public static byte Success { get; set; } = 0x00;

        /// <summary>
        /// 列表项目数错误
        /// </summary>
        public static byte ListCountError { get; set; } = 0x01;

        /// <summary>
        /// ID 错误
        /// </summary>
        public static byte IDError { get; set; } = 0x02;
    }
}
