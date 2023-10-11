using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint2.Task4.V20.Lib;

namespace Tyuiu.CherepanovVS.Sprint2.Task4.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт2                                                                   *");
            Console.WriteLine("*Тема: Тернарный оператор                                                  *");
            Console.WriteLine("*Задание #4                                                                *");
            Console.WriteLine("*Вариант #20                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с               *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение    *");
            Console.WriteLine("* переменных x,y с клавиатуры, если x + 10 > y * 2, то                     *");
            Console.WriteLine("*                            x           2                                 *");
            Console.WriteLine("* z = x * ((y + 1) / (x - 1))  , иначе x   - 1 / y;                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите значение переменной X= ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной = ");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x,y);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
