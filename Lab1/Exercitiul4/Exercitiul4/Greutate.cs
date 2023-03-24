using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul4
{
    internal class Greutate
    {
        public double greutate;
        public double Barbati(double inaltime,int varsta)
        {
            greutate= inaltime - 100 - ((inaltime - 150) / 4) + (varsta - 20) / 4; ;
            return greutate;
        }
        public double Femei(double inaltime, int varsta)
        {
            greutate = inaltime - 100 - ((inaltime - 150) / 2.5) + (varsta - 20) / 4;
            return greutate;
        }
        public void Afisare(double greutate)
        {

            Console.WriteLine("{0}",greutate);



        }
    }
}
