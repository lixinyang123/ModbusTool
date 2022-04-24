namespace Simulator.Models.CmdResults
{
    public enum Task2FlashResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 0x00,

        /// <summary>
        /// 时间戳错误（时间戳先后错误）
        /// </summary>
        TimestampError = 0x01,

        /// <summary>
        /// 存储空间错误
        /// </summary>
        StorageError = 0x02,

        /// <summary>
        /// 无任务项
        /// </summary>
        TaskNotFoundError = 0x03,

        /// <summary>
        /// 写入 Flash 错误
        /// </summary>
        FlashError = 0x04
    }
}
