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
            Console.WriteLine("qwerqwr");
        }
    }
}