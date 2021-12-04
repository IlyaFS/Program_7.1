using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите стороны второго треугольника");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int z2 = Convert.ToInt32(Console.ReadLine());
            string a;


            CalcS(x1, y1, z1, x2, y2, z2, out a);
            Console.WriteLine();
            Console.WriteLine("Площадь {0} треуольника больше", a);
            Console.ReadKey();
        }

        static void CalcS(int x1, int y1, int z1, int x2, int y2, int z2, out string a)
        {

        double p1 = (x1 + y1 + z1) / 2;
        double s1 = Math.Sqrt(p1 * (p1 - x1) * (p1 - y1) * (p1 - z1));
        double p2 = (x2 + y2 + z2) / 2;
        double s2 = Math.Sqrt(p2 * (p2 - x2) * (p2 - y2) * (p2 - z2));

        string m = "первого";
        string n = "второго";

        if (s1 > s2)
        a=m;
        else
        a=n;

        }
     }
}



