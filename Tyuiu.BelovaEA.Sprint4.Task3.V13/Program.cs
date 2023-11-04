using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint4.Task3.V13.Lib;

namespace Tyuiu.BelovaEA.Sprint4.Task3.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Белова Е. А. | ИИПб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Белова Екатерина Андреевна | ИИПб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 7. Найдите сумму элементов  *");
            Console.WriteLine("* в третьем столбце массива.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int[,] array = { { 4, 7, 4, 2, 1}, { 6, 7, 3, 6, 5 }, { 6, 5, 3, 3, 5 }, { 4, 4, 6, 4, 7 }, { 2, 1, 2, 3, 4 } };


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Матрица:\n4 7 4 2 1\n6 7 3 6 5\n6 5 3 3 5\n4 4 6 4 7\n2 1 2 3 4");
            
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Cумма элементов в третьем столбце матрицы = {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}
