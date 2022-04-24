namespace Simulator.Models.CmdResults
{
    public static class Task2FlashResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        public static byte[] Success { get; set; } = { 0x00 };

        /// <summary>
        /// 时间戳错误（时间戳先后错误）
        /// </summary>
        public static byte[] TimestampError { get; set; } = { 0x01 };

        /// <summary>
        /// 存储空间错误
        /// </summary>
        public static byte[] StorageError { get; set; } = { 0x02 };

        /// <summary>
        /// 无任务项
        /// </summary>
        public static byte[] TaskNotFoundError { get; set; } = { 0x03 };

        /// <summary>
        /// 写入 Flash 错误
        /// </summary>
        public static byte[] FlashError { get; set; } = { 0x04 };
    }
}
