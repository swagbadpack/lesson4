using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4._8_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальное число: ");
            int range = int.Parse(Console.ReadLine());
            Random r = new Random();
            int valueX = r.Next(range);
            while (true)
            {
                Console.Write("Ваше предположение:");
                string answer = Console.ReadLine();
                if (answer == "")
                {
                    Console.Write($"Загаданное число: {valueX}");
                    break;

                }
                else
                {
                    int intAnswer = Convert.ToInt32(answer);
                    if (intAnswer < valueX)
                    {
                        Console.WriteLine("Число меньше загаданного, попробуйте ещё");
                    }
                    if (intAnswer > valueX)
                    {
                        Console.WriteLine("Число больше загаданного, попробуйте ещё");
                    }
                    if (intAnswer == valueX)
                    {
                        Console.WriteLine($"Ура, вы угадали, загаданное число: {valueX} ");
                        break;
                    }
                }
                
            }
            Console.ReadKey(); 
        }
    }
}
