using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    internal class CreateTaskMsg : BaseMsg<CreateTaskResult>
    {
        public CreateTaskMsg(CreateTaskResult result) : base(0x04, CommandCode.CreateTask, result) { }

        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            return buffer.ToArray();
        }
    }
}
