using System;
using tyuiu.cources.programming.interfaces.Sprint1;
using System.Globalization;
namespace Tyuiu.BalinVV.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            number = Math.Round(number, 3);
            double rubles = 0;
            double kopeiki = 0;

            rubles = (double)number;
            double ost = (number - rubles) * 100;
            kopeiki = (double)ost;


            return $"{number} руб. - это {rubles} руб. {kopeiki} коп.";
        }
    }
}
