using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusbolFahrenheitre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Celsius = 0;
            double Farenheit = 0;

            Console.WriteLine("Add meg a hőmérsékleted Celsiusban!");
            Celsius = Convert.ToDouble(Console.ReadLine());
            Farenheit = Math.Round(Celsius * 1.8000 + 32,2);
            Console.WriteLine("A megadott Celsius Farenheitben: "+Farenheit);
            Console.ReadKey();
        }
    }
}
