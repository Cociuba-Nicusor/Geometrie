using System;

namespace curs2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, z1, x2, y2, z2, a;
            double m1, m2;
            Console.WriteLine("Introduceti valorile pt primul vector:");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            z1 = int.Parse(Console.ReadLine());
            if (y1 < 0)
                Console.WriteLine($"v1 = {x1}i {y1}j + {z1}k");
            if (y1 == 0)
                Console.WriteLine($"v1 = {x1}i + { z1}k ");
            if (z1 < 0)
                Console.WriteLine($"v1 = {x1}i + {y1}j  {z1}k");
            if (z1 == 0)
                Console.WriteLine($"v1 = {x1}i + { y1}j ");
            if (y1 > 0 && z1 > 0)
                Console.WriteLine($"v1 = {x1}i + {y1}j + {z1}k ");
            Console.WriteLine("Introduceti valorile pt primul vector:");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            z2 = int.Parse(Console.ReadLine());
            if (y2 < 0)
                Console.WriteLine($"v2 = {x2}i {y2}j + {z2}k");
            if (y2 == 0)
                Console.WriteLine($"v2 = {x2}i + { z2}k ");
            if (z2 < 0)
                Console.WriteLine($"v2 = {x2}i + {y2}j  {z2}k");
            if (z2 == 0)
                Console.WriteLine($"v2 = {x2}i + { y2}j ");
            if (y2 > 0 && z2 > 0)
                Console.WriteLine($"v2 = {x2}i + {y2}j + {z2}k ");
            
            a = (x1 * x2) + (y1 * y2) + (z1 * z2);
            Console.WriteLine($"Produsul scalar al vectorilor este {a}.");
            if (a == 0) 
            {
                Console.WriteLine("Vectorii sunt perpendiculari.");
            }
            else
            {
                Console.WriteLine("Vectorii nu sunt perpendiculari.");
            }
            m1 = Math.Sqrt(x1 * x1 + (y1 * y1) + (z1 * z1));
            m2 = Math.Sqrt(x2 * x2 + (y2 * y2) + (z2 * z2));
            Console.WriteLine($"Marimea vectorului 1 este:{m1}.");
            Console.WriteLine($"Marimea vectorului 2 este:{m2}.");
            Console.ReadKey();
        }
    }
}
