using Simulator.Models;
using System.Net;
using System.Net.Sockets;

namespace Simulator.Services
{
    public class CommService
    {
        public async Task Startup(int port)
        {
            Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Any, port));
            socket.Listen();

            Console.WriteLine($"Server run at port {port}");

            while(true)
            {
                Socket client = await socket.AcceptAsync();
                Handler(client);
            }
        }

        private void Handler(Socket socket)
        {
            while(true)
            {
                byte[] buffer = new byte[socket.ReceiveBufferSize];
                int length = socket.Receive(buffer);

                byte[] datas = new byte[length];
                Array.Copy(buffer, datas, length);

                Route(datas);
            }
        }

        private void Route(byte[] buffer)
        {
            byte cmdCode = buffer[2];

            switch (cmdCode)
            {
                case 0x00:
                    break;

                case 0x01:
                    break;

                case 0x02:
                    break;

                case 0x03:
                    break;

                case 0x04:
                    break;

                case 0x05:
                    break;

                case 0x06:
                    break;

                case 0x07:
                    break;

                case 0x08:
                    break;

                case 0x09:
                    break;

                case 0x0a:
                    break;

                case 0x0b:
                    break;

                case 0x0c:
                    break;

                case 0x0d:
                    break;

                case 0x0e:
                    break;

                case 0x0f:
                    break;

                case 0x10:
                    break;

                case 0x11:
                    break;
            }
        }
    }
}