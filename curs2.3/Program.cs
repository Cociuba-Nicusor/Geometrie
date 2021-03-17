using System;

namespace problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valori vector 1: ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valori vector 2: ");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int z2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valori vector 3: ");
            double i = int.Parse(Console.ReadLine());
            double j = int.Parse(Console.ReadLine());
            double k = int.Parse(Console.ReadLine());
            int prod = x1 * x2 + y1 * y2 + z1 * z2;
            bool perpendicular = false;
            if (prod == 0)
            {
                perpendicular = true;
            }
            double marimea1 = Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1);
            double marimea2 = Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2);
            double prodMixt = x1 * y2 * k + y1 * z2 * i + z1 * x2 * j - z1 * y2 * i - y1 * x2 * k - x1 * z2 * j;
            double volum = Math.Abs(prodMixt);
            if (prodMixt == 0)
            {
                Console.WriteLine("produs =" + prodMixt);
                Console.WriteLine("volum = 0");
                Console.WriteLine("coplanari");
            }
            else
            {
                Console.WriteLine("produs =" + prodMixt);
                Console.WriteLine("volum = " + volum);
                Console.WriteLine("nu sunt coplanari");
            }
        }
    }
}
