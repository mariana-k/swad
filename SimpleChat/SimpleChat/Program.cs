using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using SimpleChat.Communication;

namespace SimpleChat
{
    class Program
    {
        static void Main(string[] args)
        {

            Server server = new Server();
            server.StartReceiving();

            Console.ReadLine();
            
        }
    }
}
