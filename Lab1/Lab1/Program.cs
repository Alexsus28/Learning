using System;
using System.Globalization;

namespace Lab1
{
    public class zadanie1
    {
        public static void Main()
        {
            Zad1();
            Zad2();
            Zad3();
            Zad4(); //Писал  с подсказкой
            Zad5();
            Zad6();
            Zad7();
            Zad8();
        }

        public static void Zad1()
        {
            double num1 = +5.5e-2;
            float num2 = 7.8f;
            int num3 = 0;
            long num4 = 2000000000000L;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
        }
        public static void Zad2()
        {
            double pi = Math.PI;
            int tenThousand = (int)10000L;
            double tenThousandPi = pi * (int)tenThousand;
            double roundedTenThousandPi = (int)Math.Round(tenThousandPi);
            double integerPartOfTenThousandPi = (int)tenThousandPi;
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);

        }
        public static void Zad3()
        {
            double amount = 1.11; //количество биткоинов от одного человека
            int peopleCount = 60; // количество человек
            int totalMoney = (int)Math.Round(amount * peopleCount); // ← исправьте ошибку в этой строке
            Console.WriteLine(totalMoney);
        }
        public static void Zad4()
        {
            string doubleNumber = "894376.243643";
            double number = double.Parse(doubleNumber, CultureInfo.InvariantCulture); // Вася уверен, что ошибка где-то тут
            Console.WriteLine(number + 1);
        }
        public static void Zad5()
        {
            var a = 5.0;
            a = a + 0.5;
            Console.WriteLine(a);
        }
        public static void Zad6()
            {
                Console.WriteLine(GetGreetingMessage("Student", 10.01));
                Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
                Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
            }
        private static string GetGreetingMessage(string name, double salary)
        {
            return $"Hello, {name}, your salary is {Math.Ceiling(salary)}";
        }
        public static void Zad7()
        {
            Print(GetSquare(42));
        }
        private static int GetSquare(int number)
        {
            return (int)Math.Pow(number, 2);
        }
        private static void Print(int number)
        {
            Console.WriteLine(number);
        }
        public static void Zad8()
        {
            {
                Console.WriteLine(GetLastHalf("I love CSharp!"));
                Console.WriteLine(GetLastHalf("1234567890"));
                Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
            }
            static string GetLastHalf(string text)
            {
                return text.Substring(text.Length / 2).Replace(" ", "");
            }
        }
    }
}