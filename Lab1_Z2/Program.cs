using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 2. Варіант 17
            Console.Write("Введіть 4-х цифрове число: ");
            int a = int.Parse(Console.ReadLine());
            double b = Average(a);
            Console.WriteLine($"Середне значення найменьшого і найбільшого числа = {b}");
            Console.ReadLine();
        }
        static double Average(int a)
        {
            int[] nums = new int[4];
            for (int j = 0; j < 4; j++)
            {
                int k = a % 10;
                nums[j] = k;
                a = a / 10;
            }
            int min = nums[0];
            int max = nums[0];
            for (int i = 0; i < 4; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }
            
            double aver = (min + max) / 2.0;
            Console.WriteLine(min);
            Console.WriteLine(max);
            return aver;
        }
    }
}
