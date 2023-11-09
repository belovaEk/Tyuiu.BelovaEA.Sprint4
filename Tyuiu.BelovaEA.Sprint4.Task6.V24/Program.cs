using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint4.Task6.V24.Lib;

namespace Tyuiu.BelovaEA.Sprint4.Task6.V24
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант # 24                                                            *");
            Console.WriteLine("* Выполнила: Белова Екатерина Андреевна | ИИПб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Дан строковый массив данных ['Компьютер', 'Телефон', 'Планшет',         *");
            Console.WriteLine("* 'Принтер', 'Сканер', 'Монитор', 'Клавиатура'], используя класс Array,   *");
            Console.WriteLine("* выведите элементы массива, длина которых больше 7 символов.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Маcсив:\n'Компьютер', 'Телефон', 'Планшет',\n'Принтер', 'Сканер', 'Монитор', 'Клавиатура'");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string[] res = ds.Calculate(array);
            foreach (string word in res)
            {
                Console.Write(word+"\t");
            }
            Console.ReadKey();
        }
    }
}
