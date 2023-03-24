using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul2
{
    internal class Calcule
    {
       public double Adunare(double a, double b)
        {
            return a + b;
        }
        public double Scadere(double a, double b)
        {
            return a - b;
        }
        public double Inmultire(double a, double b)
        {
            return a * b;
        }
        public double Impartire(double a, double b)
        { if (b==0) return 0;
        else return a/b;
        
        }
        public void  Afisare(double a, double b,char op, double rezultat) {

            Console.WriteLine("{0}{1}{2}={3}", a, op, b, rezultat);
        
        
        
        }
    }
}
