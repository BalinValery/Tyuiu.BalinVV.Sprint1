using Tyuiu.BalinVV.Sprint1.Task0.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #0 | Выполнил Балин В. В. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Спринт #1                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("* Выполнил Балин В. В. | СМАРТб-25-1                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычесляет выражение 5 * 2 + 4 * 3           *");
        Console.WriteLine("* и печатает результат на экране                                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* 5 * 2 + 4 * 3                                                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine(ds.Calculate());

        Console.ReadLine();
    }
}