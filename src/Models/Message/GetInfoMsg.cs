using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    enum RunState
    {
        Idle = 0x00,
        Work = 0x01
    }

    enum SampleState
    {
        Waiting = 0x00,
        Sample = 0x01
    }

    enum StampValid
    {
        Yes = 0x01,
        No = 0x02
    }

    internal class GetInfoMsg : BaseMsg<GetInfoResult>
    {
        /// <summary>
        /// 运行状态
        /// </summary>
        public RunState RunState { get; }

        /// <summary>
        /// 样本状态
        /// </summary>
        public SampleState SampleState { get; }

        /// <summary>
        /// 时间戳校准状态
        /// </summary>
        public StampValid StampValid { get; }

        /// <summary>
        /// 校准表长度，0x00 为不可用
        /// </summary>
        public byte CallistSize { get; }

        /// <summary>
        /// 任务列表长度，0x00 为不可用
        /// </summary>
        public byte TasklistSize { get; }

        /// <summary>
        /// 现在所属任务列表位置，需要work态，从0开始计数
        /// </summary>
        public byte TaskPos { get; }

        /// <summary>
        /// 电池电压
        /// </summary>
        public byte[] VbatMv { get; }

        /// <summary>
        /// 最近温度值，需要进行过采集，需要校准表有效；0x00 为无效 
        /// </summary>
        public byte[] LastTemp { get; }

        public GetInfoMsg(GetInfoResult result, 
            RunState runState, 
            SampleState sampleState, 
            StampValid stampValid, 
            int callistSize,
            int tasklistSize,
            int taskPos,
            short vbatMv,
            int lastTemp) :
            base(0x0a, CommandCode.GetInfo, result) 
        {
            RunState = runState;
            SampleState = sampleState;
            StampValid = stampValid;
            CallistSize = (byte)(callistSize < 0 ? 0x00 : callistSize);
            TasklistSize = (byte)(tasklistSize < 0 ? 0x00 : tasklistSize);
            TaskPos = (byte)(taskPos < 0 ? 0x00 : taskPos);
            VbatMv = BitConverter.GetBytes(vbatMv);
            LastTemp = BitConverter.GetBytes(lastTemp);
        }

        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Convert.ToByte(RunState));
            buffer.Add(Convert.ToByte(SampleState));
            buffer.Add(Convert.ToByte(StampValid));
            buffer.Add(CallistSize);
            buffer.Add(TaskPos);
            buffer.AddRange(VbatMv);
            buffer.AddRange(LastTemp);
            return buffer.ToArray();
        }
    }
}
