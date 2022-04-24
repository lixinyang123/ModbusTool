namespace Simulator.Models.CmdResults
{
    public enum Calibration2FlashResult
    {
        /// <summary>
        /// Vmcu 错误
        /// </summary>
        VmcuError = 0x00,

        /// <summary>
        /// Vout错误（单调性错误）
        /// </summary>
        VoutError = 0x01
    }
}
