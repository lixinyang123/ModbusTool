using Simulator.Models.CmdResults;
using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class GetVersionHandler : IHandler
    {
        public byte[] Handle(byte[] msg) =>
            new GetVersionMsg(GetVersionResult.Success,
                Models.Version.SwVersion,
                Models.Version.HwVersion).GetBytes();
    }
}
