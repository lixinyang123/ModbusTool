using Simulator.Handler;
using System.Net;
using System.Net.Sockets;

namespace Simulator.Services
{
    public static class CommService
    {
        public static async Task Startup(int port)
        {
            Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Any, port));
            socket.Listen();

            Console.WriteLine($"Server run at port {port}");

            while (true)
            {
                Socket client = await socket.AcceptAsync();
                Console.WriteLine("Connect success!");
                Handler(client);
            }
        }

        private static void Handler(Socket socket)
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[socket.ReceiveBufferSize];
                    int length = socket.Receive(buffer);

                    byte[] datas = new byte[length];
                    Array.Copy(buffer, datas, length);
                    Console.Write($"<< {BitConverter.ToString(datas)}");

                    byte[] resBuffer = Route(datas);

                    Console.Write($">> {BitConverter.ToString(resBuffer)}");
                    socket.SendAsync(resBuffer);
                }
                catch (Exception)
                {
                    Console.WriteLine("Disconnect.");
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