using System.Net;
using System.Net.Sockets;

namespace Simulator.Services
{
    public class CommService
    {
        public Task Startup(int port)
        {
            Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Any, port));
            socket.Listen();

            Console.WriteLine($"Server run at port {port}");

            while(true)
            {
                Socket client = socket.Accept();
            }
        }
    }
}