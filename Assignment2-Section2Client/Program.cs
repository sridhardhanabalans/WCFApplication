using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Section2Client
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Weather Calculations!!");
            Console.Write("Enter the Celcius: ");
            double celcius= Convert.ToDouble(Console.ReadLine());
            WeatherServiceClient.WeatherServiceClient client = new WeatherServiceClient.WeatherServiceClient();
            Console.WriteLine("Equivalent Farenheit value is {0}F",client.CelciusToFarenheit(celcius).ToString());
            Console.Write("Enter the Farenheit: ");
            double farenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Equivalent Celcius value is {0}C", client.FarenheitToCelcius(farenheit).ToString());
            Console.ReadLine();
        }
    }
}
