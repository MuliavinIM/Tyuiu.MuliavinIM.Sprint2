using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MuliavinIM.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double bottom = Math.Pow(x, 2);

            double top = Math.Exp(-Math.Abs(x));

            return (y >= bottom) && (y <= top);
        }
    }
}
