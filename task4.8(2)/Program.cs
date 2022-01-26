using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4._8_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину последовательности: ");
            byte quantity = byte.Parse(Console.ReadLine());
            Console.WriteLine("Последовательно введите числа, между числами ,нажав 'Enter'");
            int[] numb = new int[quantity];
            for (int i = 0; i < numb.GetLength(0); i++)
            {
                numb[i] = int.Parse(Console.ReadLine());
            }
            int minValue = int.MaxValue;
            for (int j = 0; j < numb.GetLength(0); j++)
            {
                if (numb[j] < minValue)
                {
                    minValue = numb[j];
                }
            }
            Console.WriteLine($"Минимальное число: {minValue}");
            Console.ReadKey();

        }
    }
}
