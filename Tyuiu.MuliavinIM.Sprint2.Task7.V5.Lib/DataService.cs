using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MuliavinIM.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            if ((x >= -0.7)
                 && (x <= 0.7)
                 && (y >= Math.Pow(x, 2))
                 && (y <= Math.Exp(-Math.Abs(x))))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}