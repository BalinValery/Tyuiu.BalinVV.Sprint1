using Tyuiu.BalinVV.Sprint1.Task5.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил Балин В. В. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                                ");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                               ");
        Console.WriteLine("* Задание #5");
        Console.WriteLine("* Вариант #5");
        Console.WriteLine("* Выполнил Балин В. В. | СМАРТб-25-1");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:");
        Console.WriteLine("* Присвоить целой переменной d первую цифру из дробной части положительного");
        Console.WriteLine("*вещественного числа x                                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        double x;
        Console.WriteLine("Введите дробное число X:                                                  *");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Первая цифра дробной части = " + ds.Calculate(x));
    }
}