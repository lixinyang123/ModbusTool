namespace Simulator.Models.Message
{
    public class ClearDataMsg : BaseMsg
    {
        public ClearDataMsg(byte[] cmdCode, byte result) : base(cmdCode, result)
        {

        }

        public override byte[] GetBytes()
        {
            throw new NotImplementedException();
        }
    }
}
