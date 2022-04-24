namespace Simulator.Models.CmdResults
{
    public enum SetCalibrationResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 0x00,

        /// <summary>
        /// 列表项目数错误
        /// </summary>
        ListCountError = 0x01,

        /// <summary>
        /// ID 错误
        /// </summary>
        IDError = 0x02
    }
}
