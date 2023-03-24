using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            char op;
            Calcule x = new Calcule();
            Console.WriteLine("Introduceti doua numere reale: ");
            Console.WriteLine("a= ");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Introduceti operatia: ");
            bool keepGoing= true;
           
            
           while(keepGoing) {
                Console.WriteLine("Pentru a continua selectati operatia;Pentru a iesi apasati 0");
                Console.WriteLine("Introduceti operatia: +, -, / sau *");
                op = char.Parse(Console.ReadLine());
                
                switch (op)
                {

                    case '+': x.Afisare(a, b, op, x.Adunare(a, b)); break;
                    case '-': x.Afisare(a, b, op, x.Scadere(a, b)); break;
                    case '*': x.Afisare(a, b, op, x.Inmultire(a, b)); break;
                    case '/': x.Afisare(a, b, op, x.Impartire(a, b)); break;                   
                    default:
                          keepGoing = false;
                            break;



                }
                
            }
            Console.ReadKey();
            }
    }
}
