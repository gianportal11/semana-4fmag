using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejrcicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4;
            double promedio;
            Console.WriteLine("ingrese n1 (10%): ");
            n1= float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese n2 (20%): ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese n3 (30): ");
            n3 =float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese n4 (40%): ");
            n4 = float.Parse(Console.ReadLine());
            promedio = (n1*0.10) + (n2*0.20) + (n3*0.30) + (n4*0.40);
            Console.WriteLine("peomedio: " + promedio);
            
            if (promedio >= 11.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("APROBADO");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("DESAPROBADO");

            }

            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
