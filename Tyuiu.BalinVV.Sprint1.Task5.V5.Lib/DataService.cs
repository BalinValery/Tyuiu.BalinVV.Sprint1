using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BalinVV.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double n = x - Math.Truncate(x);
            n *= 10;
            int d = Convert.ToInt32(Math.Truncate(n));
            return d;
        }
    }
}
