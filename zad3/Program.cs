using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начало интервала : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите конец интервала : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите количество точек");
            int n = int.Parse(Console.ReadLine());

            int t = a;

            int shag = (b - a) / n;

            for (int i = 0; t >= a && t <= b && t >= 0 && i < n; i++,t += shag)
            {
                double Y = 1 + (Math.Sin(2 * Math.PI * t) / (1 + t));

                Console.WriteLine(Y);
            }

            Console.ReadLine();
        }
    }
}
