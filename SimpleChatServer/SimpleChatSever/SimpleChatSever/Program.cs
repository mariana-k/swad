using SimpleChatSever.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChatSever
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
