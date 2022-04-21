using System.IO.Ports;

namespace Simulator.Models
{
    class SerialPortConf
    {
        public SerialPortConf()
        {
            PortName = "COM1";
            BaudRate = 38400;
            Parity = Parity.None;
            StopBits = StopBits.One;
            DataBits = 8;
        }

        public string PortName { get; set; }

        public int BaudRate { get; set; }
        
        public Parity Parity { get; set; }

        public StopBits StopBits { get; set; }

        public int DataBits { get; set; }
    }
}