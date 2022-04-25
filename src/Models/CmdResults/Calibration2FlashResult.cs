namespace Simulator.Models.CmdResults
{
    public enum Calibration2FlashResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 0x00,

        /// <summary>
        /// Vmcu 错误
        /// </summary>
        VmcuError = 0x01,

        /// <summary>
        /// Vout错误（单调性错误）
        /// </summary>
        VoutError = 0x02,

        /// <summary>
        /// 电压低
        /// </summary>
        LowVoltage = 0x0a
    }
}
