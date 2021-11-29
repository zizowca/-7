using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите величину стороны куба h:\t");
            int h = Convert.ToInt32(Console.ReadLine());
            double S, V;
            GetParam(h, out S, out V);
            Console.WriteLine("\n Площадь поверхности куба S:\t={0:F2}",S);
            Console.WriteLine("\n Объем куба V:\t={0:F2}", V);
            Console.ReadKey();
        }
        static void GetParam(int h, out double S, out double V)
        {
            S = 6 * h * h;
            V = h * h * h;
        }
    }
}
