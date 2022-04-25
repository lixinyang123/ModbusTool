using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    internal class GetCalibrationMsg : BaseMsg<GetCalibrationResult>
    {
        public byte Size { get; }

        public byte Id { get; }

        public byte[] Vmcu { get; }

        public byte[] Vout { get; }

        public byte[] Div { get; }

        public GetCalibrationMsg(GetCalibrationResult result,
            int size,
            int id,
            short vmcu,
            int vout) :
            base(0x10, CommandCode.GetCalibration, result)
        {
            Size = Convert.ToByte(size);
            Id = Convert.ToByte(id);
            Vmcu = BitConverter.GetBytes(vmcu);
            Vout = BitConverter.GetBytes(vout);
            Div = BitConverter.GetBytes(vout / vmcu);
        }


        public override byte[] GetBytes()
        {
            List<byte> buffer = new() { Length };
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            buffer.Add(Size);
            buffer.Add(Id);
            buffer.AddRange(Vmcu);
            buffer.AddRange(Vout);
            buffer.AddRange(Div);
            return buffer.ToArray();
        }
    }
}
