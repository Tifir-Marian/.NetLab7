using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

using WCFIntern;

namespace ServerIntern
{
    class ServerIntern
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WCFIntern.Intern),
                        new Uri("net.tcp://localhost:8181/intern"));
            host.Open();
            Console.WriteLine("Server intern started...");
            Console.ReadLine();
            host.Close();
        }
    }
}