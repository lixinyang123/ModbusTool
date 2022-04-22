namespace Simulator.Models
{
    public class CommandCode
    {
        // 版本号
        public byte[] Version { get; set; } = { 0x00, 0x01 };

        // 开启采集
        public byte[] Start { get; set; } = { 0x00, 0x02 };

        // 停止采集
        public byte[] Stop { get; set; } = { 0x00, 0x03 };

        // 擦除数据
        public byte[] ClearData { get; set; } = { 0x00, 0x04 };

        // 获取时间戳
        public byte[] GetTime { get; set; } = { 0x00, 0x05 };

        // 校准时间
        public byte[] RegulateTime { get; set; } = { 0x00, 0x06 };

        // 设备信息
        public byte[] GetInfo { get; set; } = { 0x00, 0x07 };

        // 清空任务项
        public byte[] ClearTask { get; set; } = { 0x00, 0x08 };

        // 写任务项
        public byte[] CreateTask { get; set; } = { 0x00, 0x09 };

        // 读任务项
        public byte[] GetTask { get; set; } = { 0x00, 0x0a };

        // 存储任务项
        public byte[] SaveTask { get; set; } = { 0x00, 0x0b };

        // 读取采样数据
        public byte[] GetData { get; set; } = { 0x00, 0x0d };

        // 设置校准表项
        public byte[] SetCalibration { get; set; } = { 0x00, 0x0e };

        // 读取校准表项目
        public byte[] GetCalibration { get; set; } = { 0x00, 0x0f };

        // CMD 15
    } 
}
