namespace Simulator.Models.CmdResults
{
    public enum ClearDataResult
    {
        /// <summary>
        /// 设备处于工作状态
        /// </summary>
        Working = 0x01,

        /// <summary>
        /// 低电压
        /// </summary>
        LowVoltage = 0x0a
    }
}
