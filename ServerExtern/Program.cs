using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ServiceModel.Description;

namespace ServerExtern
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WCFExtern.Extern),
new Uri("net.tcp://localhost:8182/extern"));
            host.Open();
            Console.WriteLine("Server extern started...");
            Console.ReadLine();
            host.Close();
        }
    }
}