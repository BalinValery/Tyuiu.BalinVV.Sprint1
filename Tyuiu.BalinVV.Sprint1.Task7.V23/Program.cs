using System;
using Tyuiu.BalinVV.Sprint1.Task7.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил Балин В. В. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Спринт #1                                                                 *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #23                                                              *");
        Console.WriteLine("* Выполнил Балин В. В. | СМАРТб-25-1                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по     , *");
        Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x;
        Console.WriteLine("Введите значение X:");
        x = Convert.ToDouble(Console.ReadLine());
        double y;
        Console.WriteLine("Введите значение Y:");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = Math.Round(ds.Calculate(x, y), 3);
        Console.WriteLine($"{res}");
        Console.ReadKey();

    }
}