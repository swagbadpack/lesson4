using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шаров__Задание_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Шаров Михаил Игоревич";        //задание переменных
            byte age = 25;
            string email = "sharovmikh@yandex.ru";
            float scoresProg = 99f;
            float scoresMath = 98f;
            float scoresPhys = 97f;
            Console.WriteLine($"Ф.И.О.: {fullName} \nВозраст: {age} \nEmail: {email} \nБаллы по информатике: {scoresProg}" +        //интерполяция вывод
                $"\nБаллы по математике: {scoresMath} \nБаллы по физике: {scoresPhys}");
            Console.ReadKey();

            float amountScores = scoresProg + scoresMath + scoresPhys;         //сумма
            float middleScores = amountScores / 3;                             //среднее арифметическое
            Console.WriteLine($"Сумма баллов: {amountScores} \nСредний балл: {middleScores}");
            Console.ReadKey();
        }
    }
}
