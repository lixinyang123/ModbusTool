using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class GetInfoHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new GetInfoMsg(Models.CmdResults.GetInfoResult.Success, 
                RunState.Work, 
                SampleState.Sample, 
                StampValid.Yes, 
                10, 10, 1, 2, 3).GetBytes();
    }
}
