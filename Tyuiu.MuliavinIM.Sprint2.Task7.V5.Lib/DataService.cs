using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MuliavinIM.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            double lower = x * x;                 
            double upper = Math.Exp(-Math.Abs(x)); 

            if ((y >= lower) && (y <= upper))
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
