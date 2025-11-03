using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MuliavinIM.Sprint2.Task2.V21.Lib
{
    public class DataService : ISprint2Task2V21
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((y == 3 || y == 4 ) && (x == 3 || x >= 9 && x<= 12))
                return true;
            if ((y == 5) && (x == 3 || x >= 6 && x <= 12))
                return true;
            if ((y == 6 || y == 7) && (x >= 3 && x <= 13))
                return true;
            if ((y == 8) && (x >= 4 && x <= 6 || x >= 10 && x <= 13))
                return true;
            if ((y == 9) && (x >= 4 && x <= 6 || x >= 10 && x <= 12))
                return true;
            if ((y == 10) && (x >= 10 && x <= 12))
                return true;
            if ((y == 11) && (x >= 9 && x <= 12))
                return true;
            if ((y == 12) && (x >= 9 && x <= 10))
                return true;
            return false;
        }

    }
}