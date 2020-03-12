using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // HOMEWORK 02

            // TASK 01

            string a = "Bojan";
            string b = "Dameski";
            var concatenate = a + " " + b;
            Console.WriteLine(concatenate);


            string one = "9";
            string two = "3";
            var sum = one + two;
            Console.WriteLine(sum);
            Console.ReadLine();

            // TASK 02

            string text = "B";
            int numb = 5;
            var group = text + numb;
            Console.WriteLine(group);
            Console.ReadLine();

            // TASK 03

            int n = 102;
            int m = 5;
            var result = n / m;
            Console.WriteLine(result);
            Console.ReadLine();

            // TASK 04

            Console.Write("Input some number:");
            var inputNumber = Console.ReadLine();

            int numberValue;
            bool parseNum = int.TryParse(inputNumber, out numberValue);

            if (parseNum)
            {
                var oddEven = numberValue % 2 == 0 ? "even" : "odd";
                Console.WriteLine(oddEven);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadLine();
        }
    }
}


        

