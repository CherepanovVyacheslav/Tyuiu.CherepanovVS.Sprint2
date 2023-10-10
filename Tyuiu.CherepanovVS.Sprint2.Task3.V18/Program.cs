﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint2.Task3.V18.Lib;

namespace Tyuiu.CherepanovVS.Sprint2.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт2                                                                   *");
            Console.WriteLine("*Тема: Вложенные операторы if - else                                       *");
            Console.WriteLine("*Задание #3                                                                *");
            Console.WriteLine("*Вариант #18                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с     *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит       *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до     *");
            Console.WriteLine("* трех знаков после запятой.                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите значение переменной X= ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Значение функции = " + res);
            Console.ReadLine();
        }
    }
}
