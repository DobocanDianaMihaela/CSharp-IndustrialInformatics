using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sex;
            int varsta = 0;
            double inaltime = 0;
            Greutate femeie=new Greutate();
            Greutate barbat = new Greutate();
            Console.WriteLine("Introduceti sexul: apasati f pentru feminin si m pentru masculin: ");
            sex = char.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti inaltimea in cm: ");
            inaltime = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti varsta: ");
            varsta = int.Parse(Console.ReadLine());
            bool res;
            if (res = sex.Equals('f'))
            {
                Console.WriteLine("Greutatea ideala este: ");

                femeie.Afisare(femeie.Femei(inaltime, varsta));
            }
            else {
                if (res = sex.Equals('m'))
                {
                    Console.WriteLine("Greutatea ideala este: ");

                    barbat.Afisare(barbat.Barbati(inaltime, varsta));
                }
            }
            Console.ReadKey();

        }
    }
}
