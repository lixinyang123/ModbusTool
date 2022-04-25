using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class CreateTaskHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new CreateTaskMsg(Models.CmdResults.CreateTaskResult.Success).GetBytes();
    }
}
