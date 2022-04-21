using System.IO.Ports;
using System.Text;
using System.Text.Json;
using Simulator.Models;

namespace Simulator.Services
{
    public class CommService
    {
        private readonly string configPath = "config.json";

        private readonly SerialPortConf config;

        private SerialPort? serialPort;

        public CommService()
        {
            if(!File.Exists(configPath))
            {
                config = new SerialPortConf();
                return;
            }
            
            this.config = JsonSerializer.Deserialize<SerialPortConf>(File.ReadAllText(configPath)) ??
                new SerialPortConf();
        }

        public void Save() =>
            File.WriteAllText(configPath, JsonSerializer.Serialize(new SerialPortConf()));

        public void Start()
        {
            this.serialPort = new SerialPort()
            {
                PortName = config.PortName,
                BaudRate = config.BaudRate,
                Parity = config.Parity,
                StopBits = config.StopBits,
                DataBits = config.DataBits
            };

            serialPort.DataReceived += (o, e) => 
            {
                byte[] buffer = new byte[serialPort.ReadBufferSize];
                int length = serialPort.Read(buffer, 0, buffer.Length);    

                byte[] data = new byte[length];
                Array.Copy(buffer, data, length);

                Console.WriteLine($"<< {Encoding.UTF8.GetString(data)}");
            };

            try
            {
                serialPort.Open();
                Console.WriteLine($"Open {config.PortName} success");
            }
            catch (System.Exception)
            {
                Console.WriteLine($"Can not open {config.PortName}");
                return;
            }

            while(true)
            {
                string str = Console.ReadLine() ?? string.Empty;

                byte[] buffer = Encoding.UTF8.GetBytes(str);
                serialPort.Write(buffer, 0, buffer.Length);

                Console.WriteLine($">> {str}");
            }
        }
    }
}