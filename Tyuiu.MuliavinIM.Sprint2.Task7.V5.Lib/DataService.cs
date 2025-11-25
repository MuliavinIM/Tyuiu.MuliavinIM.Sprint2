using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MuliavinIM.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            const double a = 0.703467422498392;


            if (x < -a || x > a) return false;


            if (y < x * x) return false;


            if (x >= 0)
                return y <= Math.Exp(-x);
            else
                return y <= Math.Exp(x);
        }
    }
}
