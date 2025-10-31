using Tyuiu.BalinVV.Sprint1.Task2.V12.Lib;
internal class Program
{
     static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил Балин В. В. | СМАРТб-25-1   ";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #1                                                            *");
        Console.WriteLine("* Тема: Арфиметические операторы в C#                                  *");
        Console.WriteLine("* Задание #2                                                           *");
        Console.WriteLine("* Вариант #12                                                          *");
        Console.WriteLine("* Выполнил: Выполнил Балин В. В. | СМАРТб-25-1                         *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные");
        Console.WriteLine("* ыполняет указанные расчёты и печатает результат на экране.            ");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("Введите переменную X:");
        int x = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите переменную Y:");
        int y = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите переменную Z:");
        int z = int.Parse(Console.ReadLine()!);

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
       
        Console.WriteLine("Ответ =" + ds.CalculateParallelepipedVolume(x, y, z));
        Console.ReadKey();
    }
}