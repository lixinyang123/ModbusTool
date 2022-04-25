using Simulator.Models.Message;

namespace Simulator.Handler
{
    internal class GetDataHandler : IHandler
    {
        public byte[] Handle(byte[] msg)
        {
            int length = 10;
            List<byte> datas = new();

            Random random = new();

            Cal cal = Cal.Yes;
            //Cal cal = Cal.No;

            for (int i = 0; i < length; i++)
            {
                if (cal is Cal.Yes)
                    datas.Add(Convert.ToByte(random.Next(0, 100)));
                else
                    datas.Add(Convert.ToByte((short)random.Next(0, 100)));
            }

            return new GetDataMsg(Models.CmdResults.GetDataResult.Uploading, length, 0, cal, datas.ToArray())
                .GetBytes();
        }
    }
}
