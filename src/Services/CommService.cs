using Simulator.Handler;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Simulator.Services
{
    public static class CommService
    {
        private static Socket? socketConnect;

        public static void Startup(int port)
        {
            Socket socketListen = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketListen.Bind(new IPEndPoint(IPAddress.Any, port));
            socketListen.Listen();

            Console.WriteLine($"Server run at port {port}");

            _ = Task.Run(() =>
            {
                Listen(socketListen);
            });

            while (true)
            {
                Console.WriteLine("\nInput =>");
                string msg = Console.ReadLine() ?? string.Empty;

                List<byte> buffer = new();
                msg.Split(' ').ToList().ForEach(i => buffer.Add(Convert.ToByte(i, 16)));

                socketConnect?.SendAsync(buffer.ToArray());
            }
        }

        private static async void Listen(Socket socketListen)
        {
            while (true)
            {
                socketConnect = await socketListen.AcceptAsync();
                Console.WriteLine("\nConnect success!");
                _ = Task.Run(() =>
                {
                    Handler();
                });
            }
        }

        private static void Handler()
        {
            while (socketConnect != null)
            {
                try
                {
                    byte[] buffer = new byte[socketConnect.ReceiveBufferSize];
                    int length = socketConnect.Receive(buffer);

                    byte[] datas = new byte[length];
                    Array.Copy(buffer, datas, length);
                    Console.WriteLine($"\n<< {BitConverter.ToString(datas)}");

                    byte[] resBuffer = Route(datas);

                    Console.WriteLine($"\n>> {BitConverter.ToString(resBuffer)}");
                    socketConnect.SendAsync(resBuffer);
                }
                catch (Exception)
                {
                    socketConnect = null;
                    Console.WriteLine("\nDisconnect.");
                }
            }
        }

        private static byte[] Route(byte[] buffer) => buffer[1] switch
        {
            0x01 => new GetVersionHandler().Handle(buffer),
            0x02 => new StartHandler().Handle(buffer),
            0x03 => new StopHandler().Handle(buffer),
            0x04 => new ClearDataHandler().Handle(buffer),
            0x05 => new GetTimeHandler().Handle(buffer),
            0x06 => new CalibratedTimeHandler().Handle(buffer),
            0x07 => new GetInfoHandler().Handle(buffer),
            0x08 => new ClearTaskHandler().Handle(buffer),
            0x09 => new CreateTaskHandler().Handle(buffer),
            0x0a => new GetTaskHandler().Handle(buffer),
            0x0b => new Task2FlashHandler().Handle(buffer),
            0x0d => new GetDataHandler().Handle(buffer),
            0x0e => new SetCalibrationHandler().Handle(buffer),
            0x0f => new GetCalibrationHandler().Handle(buffer),
            0x10 => new Calibration2FlashHandler().Handle(buffer),
            0x11 => new FindExecTagHandler().Handle(buffer),
            _ => throw new NotImplementedException()
        };
    }
}