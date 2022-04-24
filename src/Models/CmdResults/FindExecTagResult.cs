namespace Simulator.Models.CmdResults
{
    public static class FindExecTagResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        public static byte Success { get; set; } = 0x00;

        /// <summary>
        /// 失败
        /// </summary>
        public static byte Error { get; set; } = 0x01;
    }
}
