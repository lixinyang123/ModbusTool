namespace Simulator.Models.CmdResults
{
    public enum GetCalibrationResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 0x00,

        /// <summary>
        /// 校准表错误
        /// </summary>
        CalibratedError = 0x01,

        /// <summary>
        /// ID 错误
        /// </summary>
        IDError = 0x02
    }
}
