using System;

namespace Home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            //Home work: Initial stuff

            // № 1
            Console.WriteLine("Hello! What is you name?");

            string a = Console.ReadLine();
            string b = "Well hello, ";
            {
                Console.WriteLine(b + a);
            }

            Console.WriteLine("Wanna buy some elephant?");

            string c = Console.ReadLine();

            if (c == "No")
            {
                Console.WriteLine("Everyone says \"No\", but you buy elephant");
            }
            else if (c == "Yes")
            {
                Console.WriteLine("Relax, just a joke");
            }

            // № 2
            Console.WriteLine("Напишите любое число");

            int с = int.Parse(Console.ReadLine());

            if ((с % 2) == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }

            // # 3 калькулятор
            Console.WriteLine("Enter first number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator(+ - * /):");

            string sign = Console.ReadLine();
            string d = "Resalt:";
            if (sign == "+")
            {
                Console.WriteLine(d + (x + y));
            }
            else if (sign == "-")
            {
                Console.WriteLine(d + (x - y));
            }
            else if (sign == "*")
            {
                Console.WriteLine(d + (x * y));
            }
            else if (sign == "/")
            {
                Console.WriteLine(d + (x / y));
            }

            //# 4 (max)
            int[] myArray = { 3, 5, 7, 10, 11, 12, 2 };

            int maxValue = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > maxValue)
                {
                    maxValue = myArray[i];
                }
            }
            Console.WriteLine(maxValue);

        }
    }
}
