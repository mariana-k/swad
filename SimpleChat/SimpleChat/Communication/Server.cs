using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace SimpleChat.Communication
{
    class Server
    {
         private Socket serverSock, clientSock;

        public Server()
        {
            serverSock = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);
            Console.WriteLine("Socket created");
            serverSock.Bind(
                new IPEndPoint(IPAddress.Loopback, 8055)); //10.201.90.53
            Console.WriteLine("Binding done");
            serverSock.Listen(5);
            Console.WriteLine("Listening started");
            clientSock = serverSock.Accept();
            Console.WriteLine("Accepting started");

        }

        public void StartReceiving()
        {
            byte[] buffer = new byte[512];
            int length;
            string ip = (clientSock.LocalEndPoint as IPEndPoint).Address.ToString();
            string name = "";
            string message = "";

            #region Get Name
            do
            {
                length = clientSock.Receive(buffer);
                name += Encoding.UTF8.GetString(buffer, 0, length);

            } while (!name.Contains("\r\n"));
            name = name.Substring(0, name.Length - 2);

            clientSock.Send(Encoding.UTF8.GetBytes("Hello " + name));

            #endregion

            while (true)
            {

                length = clientSock.Receive(buffer);
                message += Encoding.UTF8.GetString(buffer, 0, length);
                if (message.Contains("\r\n"))
                {
                    Console.Write(name + " : " + message);
                    message = "";
                }
            }
        }

    }
}
