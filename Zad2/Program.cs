using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение y : ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите значение z : ");
            double z = double.Parse(Console.ReadLine());

            if(x + y + z > 10)
            {
                if(x < y && x < z)
                {
                    x = (y + z) / 2;
                }
                else if(y < x && y < z)
                {
                    y = (x + z) / 2;
                }
                else if(z < x && z < y)
                {
                    z = (x + y) / 2;
                }
            }
            else
            {
                x += 10;
                y += 10;
                z += 10;
            }

            Console.WriteLine(x + " " + y + " " + z);

            Console.ReadLine();
        }
    }
}
