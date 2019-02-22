using System;
using System.ServiceModel;

namespace WCFServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(Assignment1_Section1.SayHello)))
            {
                host.Open();
                Console.WriteLine("The host is open");
                Console.ReadLine();
            }
        }
    }
}
