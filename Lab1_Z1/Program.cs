using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Z1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double minMul = MinMul(a, b, c);
            double minPlus = MinPlus(a, b, c);
            Console.WriteLine(minMul);
            Console.WriteLine(minPlus);
            if (minMul > minPlus)
            {
                Console.WriteLine($"y = {minMul}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"y = {minPlus}");
                Console.ReadLine();
            }
        }
        static double MinMul(double a, double b, double c)
        {
            if (a * b > a * c)
                return a * c;
            else
                return a * b;
        }
        static double MinPlus(double a, double b, double c)
        {
            if (a + b > a + c)
                return a + c;
            else
                return a + b;
        }
    }
}
