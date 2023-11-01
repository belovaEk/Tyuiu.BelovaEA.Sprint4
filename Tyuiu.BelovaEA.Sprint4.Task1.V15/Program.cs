using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint4.Task1.V15.Lib;

namespace Tyuiu.BelovaEA.Sprint4.Task1.V15
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Белова Екатерина Андреевна | ИИПб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 9, подсчитать произведение  *");
            Console.WriteLine("* чётных элементов массива.                                               *");
            Console.WriteLine("* С клавиатуры: 6, 7, 6, 7, 5, 7, 6, 7, 9, 4, 6, 5, 8, 5                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int len = 14;
            int[] array = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }    


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Массив = ");
            for (int i = 0; i <array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение чётных элементов = {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}
