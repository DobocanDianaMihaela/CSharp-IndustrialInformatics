using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Introduceti numarul de termeni care se vor afisa: ");
          
           n=int.Parse(Console.ReadLine());//convertesc un string in int cu metoda Parse
           // n = Convert.ToInt32(Console.ReadLine());//convertesc folosinf clasa Convert
           for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Fibonacci [{0}] este {1}",i, Fibonacci(i));

            }
         
            Console.ReadKey();
    }
      static  int Fibonacci(int n)//am folosit static pentru a putea apela metoda in main fara a instantia uh=n obiect de tipul Program
        {//conditie de oprire
            if (n == 0 || n == 1) return n;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);

        
        
        }
    }
}
