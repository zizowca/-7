using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение стороны х1 треугольника №1:\t ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение стороны y1 треугольника №1:\t ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение стороны z1 треугольника №1:\t ");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение стороны х2 треугольника №2:\t ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение стороны y2 треугольника №2:\t ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение стороны z2 треугольника №2:\t ");
            int z2 = Convert.ToInt32(Console.ReadLine());
            double S1 = STriangle(x1, y1, z1);
            double S2 = STriangle(x2, y2, z2);
            Console.WriteLine("\nПлощадь треугольника №1 \t={0:F2}", S1);
            Console.WriteLine("\nПлощадь треугольника №1 \t={0:F2}", S2);
            if (S1>S2)
            {
                Console.WriteLine("\nПлощадь треугольника №1 больше, чем площадь треугольника №2");
            }
            else if (S2>S1)
            {
                Console.WriteLine("\nПлощадь треугольника №2 больше, чем площадь треугольника №1");
            }
            else
            {
                Console.WriteLine("\nПлощади треугольников равны");
            }
            Console.ReadKey();
        }
        static double STriangle(int x,int y,int z)
        {
               double p = (x + y + z) / 2;
               double S = Math.Sqrt(p * (p - (double)x) * (p - (double)y) * (p - (double)z));
               return S;
        }
    }
}
