using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Begin();
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static void Begin()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the calculator");
            double x = FirstValue();
            double y = SecondValue();
            char output = Operator();
            double amount;

            switch (output)
            {
                case '+':
                    amount = x + y;
                    Console.WriteLine("Your result  =   " + amount);
                    Console.WriteLine("To exit press Escape, and any other key to continue");
                    break;
                case '-':
                    amount = x - y;
                    Console.WriteLine("Your result  =   " + amount);
                    Console.WriteLine("To exit press Escape, and any other key to continue");
                    break;
                case '*':
                    amount = x * y;
                    Console.WriteLine("Your result  =   " + amount);
                    Console.WriteLine("To exit press Escape, and any other key to continue");
                    break;
                case '/':
                    amount = x / y;
                    Console.WriteLine("Your result  =   " + amount);
                    Console.WriteLine("To exit press Escape, and any other key to continue");
                    break;
                default:
                    Console.WriteLine("Wow! Your input is incorrect");
                    Console.WriteLine("To exit press Escape, and any other key to continue");
                    break;
            }
        }

        public static double FirstValue()
        {
            double x;
            Console.WriteLine("Enter the first value:");
            x = Convert.ToDouble(Console.ReadLine());
            return x;
        }

        public static double SecondValue()
        {
            double y;
            Console.WriteLine("Enter the second value:");
            y = Convert.ToDouble(Console.ReadLine());
            return y;
        }

        public static char Operator()
        {
            char output;
            Console.WriteLine("Select a mathematical operation:");
            Console.WriteLine(" +");
            Console.WriteLine(" -");
            Console.WriteLine(" *");
            Console.WriteLine(" /");
            Console.WriteLine("Input the operator:");
            output = Convert.ToChar(Console.ReadLine());
            return output;
        }

    }

}

