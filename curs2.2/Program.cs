using System;

namespace curs2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, z1, x2, y2, z2, a;
            
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
            Console.WriteLine("Introduceti valorile pt al doilea vector:");
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
            double i = y1 * z2 - z1 * y2;
            double j = -1 * (x1 * z2 - z1 * x2);
            double k = x1 * y2 - y1 * x2;
            if (i == 0 && j == 0 && k == 0)
            {
                Console.WriteLine("produs vectorial = 0");
                Console.WriteLine("COLINIARITATE");
            }
            else
            {
                if (i != 0)
                    Console.Write(i + "i");
                else if (i == 0)
                    Console.Write("");
                if (j > 0 && i != 0)
                    Console.Write("+" + j + "j");
                else if (j > 0 && i == 0)
                    Console.Write("" + j + "j");
                else if (j < 0)
                    Console.Write(j + "j");
                else if (j == 0)
                    Console.Write("");
                if (k > 0)
                    Console.Write("+" + k + "k");
                else if (k < 0)
                    Console.Write(k + "k");
                else if (k == 0)
                    Console.WriteLine("");
                Console.WriteLine("ARIA: " + Math.Sqrt(i * i + j * j + k * k));
                Console.WriteLine();
                Console.WriteLine("NU SUNT COLINIARE");
                Console.WriteLine();
            }
        }
    }
}
