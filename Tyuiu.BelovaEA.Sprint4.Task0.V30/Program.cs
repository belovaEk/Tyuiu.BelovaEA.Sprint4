using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint4.Task0.V30.Lib;

namespace Tyuiu.BelovaEA.Sprint4.Task0.V30
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила: Белова Екатерина Андреевна | ИИПб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9, подсчитать сумму         *");
            Console.WriteLine("* чётных элементов массива.  {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив = {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма чётных элементов = {ds.GetSumEvenArrEl(array)}");
            Console.ReadKey();
        }
    }
}
