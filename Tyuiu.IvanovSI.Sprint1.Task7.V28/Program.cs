using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint1.Task7.V28.Lib;

namespace Tyuiu.IvanovSI.Sprint1.Task7.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Иванов С. И. | РПСб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задания #7                                                               *");
            Console.WriteLine("* Вариант #28                                                              *");
            Console.WriteLine("* Выполнил: Иванов Семён Иванович | РПСб-23-1                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое                     *");
            Console.WriteLine("* выражение по исходным значениям данных, вводимых пользователем.          *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");




            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значени y:");
            double y = Convert.ToDouble(Console.ReadLine());





            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            double res = Math.Round(ds.Calculate(x, y), 3);


            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
