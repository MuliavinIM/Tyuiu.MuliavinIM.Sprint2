using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MuliavinIM.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double bottom = x * x;

            double top = Math.Exp(-Math.Abs(x));
            const double eps = 1e-9;
            return (y + eps >= bottom) && (y <= top + eps);
        }
    }
}
