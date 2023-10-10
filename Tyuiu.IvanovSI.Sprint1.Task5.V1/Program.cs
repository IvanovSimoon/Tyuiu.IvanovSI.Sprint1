using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint1.Task5.V1.Lib;

namespace Tyuiu.IvanovSI.Sprint1.Task5.V1
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
            Console.WriteLine("* Задания #5                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнил: Иванов Семён Иванович | РПСб-23-1                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y),    *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            
          

            Console.WriteLine("Введите значение x1:");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение x2:");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y1:");
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y2:");
            double y2 = Convert.ToInt32(Console.ReadLine());





            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2));


            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
