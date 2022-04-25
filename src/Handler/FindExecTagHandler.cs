using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class FindExecTagHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new FindExecTagMsg(Models.CmdResults.FindExecTagResult.Success, Clear.Yes, 5).GetBytes();
    }
}
