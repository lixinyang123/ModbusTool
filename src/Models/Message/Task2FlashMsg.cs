using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    internal class Task2FlashMsg : BaseMsg<Task2FlashResult>
    {
        public Task2FlashMsg(Task2FlashResult result) : base(0x04, CommandCode.Task2Flash, result) { }

        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            return buffer.ToArray();
        }
    }
}
