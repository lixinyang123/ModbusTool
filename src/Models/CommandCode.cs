namespace Simulator.Models
{
    public static class CommandCode
    {
        /// <summary>
        /// 版本号
        /// </summary>
        public static byte[] GetVersion { get; set; } = { 0x00, 0x01 };

        /// <summary>
        /// 开启采集
        /// </summary>
        public static byte[] Start { get; set; } = { 0x00, 0x02 };

        /// <summary>
        /// 停止采集
        /// </summary>
        public static byte[] Stop { get; set; } = { 0x00, 0x03 };

        /// <summary>
        /// 擦除数据
        /// </summary>
        public static byte[] ClearData { get; set; } = { 0x00, 0x04 };

        /// <summary>
        /// 获取时间戳
        /// </summary>
        public static byte[] GetTime { get; set; } = { 0x00, 0x05 };

        /// <summary>
        /// 校准时间
        /// </summary>
        public static byte[] CalibratedTime { get; set; } = { 0x00, 0x06 };

        /// <summary>
        /// 设备信息
        /// </summary>
        public static byte[] GetInfo { get; set; } = { 0x00, 0x07 };

        /// <summary>
        /// 清空任务列表
        /// </summary>
        public static byte[] ClearTask { get; set; } = { 0x00, 0x08 };

        /// <summary>
        /// 写任务项
        /// </summary>
        public static byte[] CreateTask { get; set; } = { 0x00, 0x09 };

        /// <summary>
        /// 读任务项
        /// </summary>
        public static byte[] GetTask { get; set; } = { 0x00, 0x0a };

        /// <summary>
        /// 任务列表写入 Flash
        /// </summary>
        public static byte[] Task2Flash { get; set; } = { 0x00, 0x0b };

        /// <summary>
        /// 读取采样数据
        /// </summary>
        public static byte[] GetData { get; set; } = { 0x00, 0x0d };

        /// <summary>
        /// 设置校准表项
        /// </summary>
        public static byte[] SetCalibration { get; set; } = { 0x00, 0x0e };

        /// <summary>
        /// 读取校准表项目
        /// </summary>
        public static byte[] GetCalibration { get; set; } = { 0x00, 0x0f };

        /// <summary>
        /// 校准表写入 Flash
        /// </summary>
        public static byte[] Calibration2Flash { get; set; } = { 0x00, 0x10 };

        /// <summary>
        /// 查询执行标记
        /// </summary>
        public static byte[] FindExecTag { get; set; } = { 0x00, 0x11 };
    }
}
