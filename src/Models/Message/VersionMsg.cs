﻿using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    public class VersionMsg: BaseMsg<VersionResult>
    {
        /// <summary>
        /// 硬件版本 Version
        /// </summary>
        public byte[] HwVersion { get; }

        /// <summary>
        /// 软件版本 Version
        /// </summary>
        public byte[] SwVersion { get; }

        public VersionMsg(VersionResult result, byte[] hwVersion, byte[] swVersion) : 
            base(0x0c, CommandCode.Version, result)
        {
            HwVersion = hwVersion;
            SwVersion = swVersion;
        }

        /// <summary>
        /// 读取完整消息
        /// </summary>
        /// <returns>消息buffer</returns>
        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            buffer.AddRange(HwVersion);
            buffer.AddRange(SwVersion);
            return buffer.ToArray();
        }
    }
}