using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = 0, fah = 0;
            Console.WriteLine("introduceti temperatura in Grade Celsius: ");
            celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("introduceti temperatura in Grade Fahrenheit: ");
            fah = double.Parse(Console.ReadLine());
            Console.WriteLine("Temperatura din Celsius in Fah este: {0} ",CelsiusToFah(celsius));
            Console.WriteLine("Temperatura din Fah in Celsius este: {0} ", FahToCelsius(fah));
            Console.ReadKey();



        }
        static double CelsiusToFah(double celsius)
        {
            return (celsius * 9 / 5 + 32);
        }
        static double FahToCelsius(double fah)
        {
            return ((fah - 32) * 5 / 9);
        }
    }
}
