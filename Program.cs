using System;


namespace ulearn 
{
    internal class Program
    {
        private static string GetMinX(int a, int b, int c)
        {
            if (a < 0)
            {
                return "Impossible";
            }
            else
            {
                double x = -(b / (2.0 * a));
                return(x).ToString();
            }
            
        }
        static void Main()
        {
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));
        }
    }
}