using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BalinVV.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            return "" + Convert.ToInt32(value[0]);
        }
    }
}
