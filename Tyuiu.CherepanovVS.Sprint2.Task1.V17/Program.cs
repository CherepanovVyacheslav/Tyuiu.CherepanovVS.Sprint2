using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint2.Task1.V17.Lib;

namespace Tyuiu.CherepanovVS.Sprint2.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 135;
            int b = 123;
            int c = 455;
            int d = 321;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.Title = "Спринт #1 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт2                                                                   *");
            Console.WriteLine("*Тема: Логические операции                                                 *");
            Console.WriteLine("*Задание #1                                                                *");
            Console.WriteLine("*Вариант #17                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,          *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в          *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^, последовательность *");
            Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,        *");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (True, False,      *");
            Console.WriteLine("* True, True, True, False), при a = 135, b = 123, c = 455, d = 321         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }
}
