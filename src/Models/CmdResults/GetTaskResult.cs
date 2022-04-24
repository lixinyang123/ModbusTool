namespace Simulator.Models.CmdResults
{
    public static class GetTaskResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        public static byte[] Success { get; set; } = { 0x00 };

        /// <summary>
        /// 错误（空项或段超范围）
        /// </summary>
        public static byte[] Error { get; set; } = { 0x01 };
    }
}
