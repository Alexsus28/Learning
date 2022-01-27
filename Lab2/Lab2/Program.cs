using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie();
            Zadanie2();
        }

        public static void Zadanie()
        {
            Console.WriteLine("Hello, World!");
            var number = 5.5;
            number += 7.0;
            Console.WriteLine(number);
        }
    
        public static void Zadanie2()
        {
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));
 
            // А в этих случаях решение существует:
            Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
            Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
        }
        private static string GetMinX(int a, int b, int c)
        {
            string result = "Impossible";
            if (a == 0 && b == 0) return c.ToString();
            if (a != 0) result = ((double)-1 * b / (2 * a)) + "";
            return result;
        }
    }
}

