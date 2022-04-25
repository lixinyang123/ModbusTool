using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class GetTimeHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new GetTimeMsg(Models.CmdResults.GetTimeResult.Success,
                Convert.ToInt32(DateTimeOffset.Now.ToUnixTimeSeconds()))
            .GetBytes();
    }
}
