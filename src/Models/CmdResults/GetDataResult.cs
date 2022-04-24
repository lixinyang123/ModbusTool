namespace Simulator.Models.CmdResults
{
    public enum GetDataResult
    {
        /// <summary>
        /// 包上传
        /// </summary>
        Uploading = 0x00,
        
        /// <summary>
        /// 完成包上传
        /// </summary>
        Uploaded = 0xff,

        /// <summary>
        /// 采样点 id 逻辑错误
        /// </summary>
        SamplingIdError = 0x01,

        /// <summary>
        /// 段为空
        /// </summary>
        SegmentEmptyError = 0x02,

        /// <summary>
        /// 采样点越界（采样点超段范围）
        /// </summary>
        SamplingOutOfBoundsError = 0x03,

        /// <summary>
        /// 任务列表无效
        /// </summary>
        TaskListError = 0x04,

        /// <summary>
        /// 校准表无效
        /// </summary>
        CalibratedError = 0x05,

        /// <summary>
        /// 电压低
        /// </summary>
        LowVoltage = 0x0a
    }
}
