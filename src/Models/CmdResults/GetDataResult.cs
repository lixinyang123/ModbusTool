namespace Simulator.Models.CmdResults
{
    public static class GetDataResult
    {
        /// <summary>
        /// 包上传
        /// </summary>
        public static byte[] Uploading { get; set; } = { 0x00 };
        
        /// <summary>
        /// 完成包上传
        /// </summary>
        public static byte[] Uploaded { get; set; } = { 0xff };

        /// <summary>
        /// 采样点 id 逻辑错误
        /// </summary>
        public static byte[] SamplingIdError { get; set; } = { 0x01 };

        /// <summary>
        /// 段为空
        /// </summary>
        public static byte[] SegmentEmptyError { get; set; } = { 0x02 };

        /// <summary>
        /// 采样点越界（采样点超段范围）
        /// </summary>
        public static byte[] SamplingOutOfBoundsError { get; set; } = { 0x03 };

        /// <summary>
        /// 任务列表无效
        /// </summary>
        public static byte[] TaskListError { get; set; } = { 0x04 };

        /// <summary>
        /// 校准表无效
        /// </summary>
        public static byte[] CalibratedError { get; set; } = { 0x05 };

        /// <summary>
        /// 电压低
        /// </summary>
        public static byte[] LowVoltage { get; set; } = { 0x0a };
    }
}
