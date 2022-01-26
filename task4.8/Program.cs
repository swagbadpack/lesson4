using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            byte lineM = byte.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            byte pillarM = byte.Parse(Console.ReadLine());
            int[,] matrix = new int[lineM, pillarM];
            Random r = new Random();
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(5);
                    Console.Write($"{matrix[i, j]} ");
                    sum = sum + matrix[i, j];
                                        
                }
            }
            Console.WriteLine($"\nСумма: {sum}");
            Console.ReadKey();
        }
    }
}
