using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint4.Task5.V23.Lib;

namespace Tyuiu.BelovaEA.Sprint4.Task5.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Белова Е. А. | ИИПб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Белова Екатерина Андреевна | ИИПб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -4 до 8.                           *");
            Console.WriteLine("* Заменить отрицательные элементы на 0.                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int str = 5;
            int stl = 5;
            int[,] array = new int[str, stl];

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stl; j++)
                {

                    array[i, j] = rnd.Next(-4, 8);
                }

            }


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Массив:\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] res = ds.Calculate(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
