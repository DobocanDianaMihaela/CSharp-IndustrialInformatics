using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Intorduceti numarul de elemente din vector: ");
            n=int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for(int i=0;i<n;i++)
            { Console.WriteLine("v [{0}]= ", i);

                v[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", v[i]);
            }
            Console.WriteLine("Media Aritmetica este: {0}",Aritmetica(v,n));
            Console.WriteLine("Media Geometrica este: {0}", Geometrica(v, n));
            Console.ReadKey();
        }
        static double Aritmetica(int[]v,int n)
        {
            double suma = 0;
            for(int i =0;i<n;i++)
            {
                suma = suma + v[i];
            }
            return suma / n;

         
        }
        static double Geometrica(int[] v, int n)
        {

            double produs = 1;
            for (int i = 0; i < n; i++)
            {
                produs = produs* v[i];
            }
            double mediaGeom = (double)Math.Pow(produs, (double)1 / n);
            return mediaGeom;

        }
        
        
    }
    
}
