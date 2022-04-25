using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class Task2FlashHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new Task2FlashMsg(Models.CmdResults.Task2FlashResult.Success).GetBytes();
    }
}
