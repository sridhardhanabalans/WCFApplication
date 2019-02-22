using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(Assignment1_Section3.Calculator)))
            {
                host.Open();
                Console.WriteLine("Calculator service is open");
                Console.ReadLine();
            }
        }
    }
}
