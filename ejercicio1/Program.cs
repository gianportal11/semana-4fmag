using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ax*2 +bx + c 
            //2 soluciones
            //disc> 0 -> 2sol
            //disc = 0 -> 1sol
            //disc< 0-> 0 sol
            int a, b, c, disc;
            double x1, x2;
            
            
            Console.Write("ingrese el valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("ingrese el valor de b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("ingrese el valor de c: ");
            c = int.Parse(Console.ReadLine());
            disc = (b * b) - (4 * a * c);

            if (disc > 0)
            {
                x1 = (-b - Math.Sqrt(disc)) / 2 * a;
                x2 = (-b + Math.Sqrt(disc)) / 2 * a;
                Console.WriteLine("x1: " + x1);
                Console.WriteLine("x2: " + x2);
            }
            else
            { if (disc==0)
                { x1 = -b / 2 * a;
                    Console.WriteLine("x1: " + x1);
                    
                }
            else { Console.WriteLine  ("no tiene soluciones"); }
            }

        }
    }
}
