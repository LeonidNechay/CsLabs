using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Z1();
            Z2();
            Console.ReadLine();
        }

        static void Z1()
        {
            Console.Write("Введіть розмірність вектора: ");
            int n = int.Parse(Console.ReadLine());
            double[] v = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введіть {i + 1} координату: ");
                v[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Мінімальне значення = {MinZ1(v, n)}");
            Console.ReadLine();
        }
        static double MinZ1(double[] v, int n)
        {
            double[] minV = new double[n];
            minV[0] = v[0];
            for (int i = 1; i < n; i++)
            {
                minV[i] = minV[i - 1] + v[i];
            }
            double min_num = minV.Min();
            return min_num;
        }
        static void Z2()
        {
            Console.Write("Введіть розмірність матриці: ");
            int m = int.Parse(Console.ReadLine());
            double[,] matrix = new double[m,m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{i + 1}{j + 1}: ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
            double maxN = MaxZ2(matrix, m);
            for (int i = 1;i < m; i++)
            {
                for(int j = 0; j < m;j++)
                {
                    if (j >= i)
                        continue;
                    matrix[i, j] = maxN;
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static double MaxZ2(double[,] matrix, int m)
        {
            double max = matrix[0,0];
            for(int i = 0; i < m; i++)
            {
                for( int j = 0; j < m; j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }
    }
}