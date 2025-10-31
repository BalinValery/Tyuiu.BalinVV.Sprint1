using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BalinVV.Sprint1.Task7.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            return x - Math.Pow(10, x * Math.Log(x)) + (20 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3)) + Math.Cos(Math.Pow(x, 2) - y);
        }
    }
}
