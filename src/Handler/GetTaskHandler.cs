using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class GetTaskHandler : IHandler
    {
        public byte[] Handle(byte[] msg)
        {
            int startTime = Convert.ToInt32(DateTimeOffset.Now.ToUnixTimeSeconds());
            int endTime = Convert.ToInt32(DateTimeOffset.Now.ToUnixTimeSeconds());

            return new GetTaskMsg(Models.CmdResults.GetTaskResult.Success, 1, startTime, endTime, 1, 2, 3, 20)
                .GetBytes();
        }
    }
}
