using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelovLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x  : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение z : ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Введите значение y : ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите значение n : ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Введите значение a : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение d : ");
            double d = double.Parse(Console.ReadLine());

            x = x * Math.PI / 180;
            y = y * Math.PI / 180;
            z = z * Math.PI / 180;
            n = n * Math.PI / 180;

            double R = (Math.Cos(x - z) + Math.Atan(y + n)) / (Math.Pow(Math.E, a - b) - Math.Log(z / d));

            Console.WriteLine(R);

            Console.ReadLine();
        }
    }
}
