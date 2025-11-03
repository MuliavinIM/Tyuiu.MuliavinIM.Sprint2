using Tyuiu.MuliavinIM.Sprint2.Task2.V21.Lib;
namespace Tyuiu.MuliavinIM.Sprint2.Task2.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 |Выполнил: Мулявин И. М. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Мулявин Иван Михайлович |ИСТНб-25-1|                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x=" + x);
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y=" + y);

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res)
            { Console.WriteLine("Находится в области"); }
            else
            { Console.WriteLine("Не находится в области"); }
            Console.ReadKey();
        }
    }
}