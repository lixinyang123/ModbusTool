namespace Simulator.Models.CmdResults
{
    public enum GetTaskResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 0x00,

        /// <summary>
        /// 错误（空项或段超范围）
        /// </summary>
        Error = 0x01
    }
}
