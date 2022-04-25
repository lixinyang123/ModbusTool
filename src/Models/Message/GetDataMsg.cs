using Simulator.Models.CmdResults;

namespace Simulator.Models.Message
{
    /// <summary>
    /// 是否校准过
    /// </summary>
    enum Cal
    {
        Yes = 0x00,
        No = 0x01
    }

    internal class GetDataMsg : BaseMsg<GetDataResult>
    {
        /// <summary>
        /// 本包抽样点数
        /// </summary>
        public byte Num { get; }

        /// <summary>
        /// 本包第一个数据的采样id
        /// </summary>
        public byte[] PkgSample0Id { get; }

        /// <summary>
        /// 是否校准过
        /// </summary>
        public byte Cal { get; }

        /// <summary>
        /// 数据序列 (采样原始数据序列 16bit short) 或 (校准后数据序列 32bit int)
        /// </summary>
        public byte[] DataArray { get; }

        public GetDataMsg(GetDataResult result,
            int num,
            int pkgSample0Id,
            Cal cal,
            byte[] dataArray)
            : base(0x00, CommandCode.GetData, result)
        {
            PkgSample0Id = BitConverter.GetBytes(pkgSample0Id);
            Cal = Convert.ToByte(cal);
            Num = Convert.ToByte(num);
            DataArray = dataArray;
        }

        public override byte[] GetBytes()
        {
            List<byte> buffer = new();
            buffer.AddRange(CmdCode);
            buffer.Add(Result);
            buffer.Add(Num);
            buffer.AddRange(PkgSample0Id);
            buffer.Add(Cal);
            buffer.AddRange(DataArray);
            buffer.Insert(0, Convert.ToByte(buffer.Count + 1));
            return buffer.ToArray();
        }
    }
}
