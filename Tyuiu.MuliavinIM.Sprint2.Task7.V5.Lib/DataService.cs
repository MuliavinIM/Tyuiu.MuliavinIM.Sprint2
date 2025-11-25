using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MuliavinIM.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            bool condBottom = y >= Math.Pow(x, 2);
            bool condTop = y <= Math.Exp(-Math.Abs(x));
            bool condX = (x >= -1) && (x <= 1);
            bool condY = y >= 0;

            if (condBottom && condTop && condX && condY)
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
