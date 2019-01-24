using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChatSever.Communication
{
    class Server
    {
        private Socket serverSock, clientSock;
        private byte[] buffer = new byte[512];
        public Server()
        {
            serverSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Console.WriteLine("Socket created");
            serverSock.Bind(
                new IPEndPoint(IPAddress.Loopback, 8055));
            Console.WriteLine("Binding done");
            serverSock.Listen(5);
            Console.WriteLine("LIstening started");
            clientSock = serverSock.Accept();
            Console.WriteLine("New client accepted");
        }
        public void StartReceiving()
        {
            while(true) { 
            int length = clientSock.Receive(buffer);
            string temp = Encoding.UTF8.GetString(buffer, 0, length);
            Console.Write(temp);
            }
        }
    }
}
