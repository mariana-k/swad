using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CD5_Kyrkosh.Communication
{
    class Server
    {
        private Socket serverSock, clientSock;
        public Server()
        {
            serverSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.WriteLine("Socket created"));
            serverSock.Bind(
                new IPEndPoint(IPAddress.Loopback, 8055));
            Console.WriteLine("Binding done");
            serverSock.Listen(5);
            Console.WriteLine("LIstening started");
            serverSock.Accept();
        }
    }
}
