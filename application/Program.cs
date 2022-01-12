using System;
using System.Net;
using System.Net.Sockets;
namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var ipAddress = IPAddress.Any;
            int portNumber = 23000;

            var ipEndpoint = new IPEndPoint(ipAddress, portNumber);

            listenerSocket.Bind(ipEndpoint);

            listenerSocket.Listen(5);
            listenerSocket.Accept();


        }
    }
}
