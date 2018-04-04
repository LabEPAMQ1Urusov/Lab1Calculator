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

            double x;
            double y;
            double amount;
            char output;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the calculator");
                Console.WriteLine("Select a mathematical operation:");
                Console.WriteLine(" +");
                Console.WriteLine(" -");
                Console.WriteLine(" *");
                Console.WriteLine(" /");
                Console.WriteLine("Input the operator:");
                output = Convert.ToChar(Console.ReadLine());




                if (output == '+')
                {
                    Console.WriteLine("Enter the first value:");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second value:");
                    y = Convert.ToDouble(Console.ReadLine());
                    amount = x + y;
                    Console.WriteLine("Your result  =   " + amount);
                    Console.WriteLine("To exit press Escape, and any other key to continue");
                }

                else if (output == '-')
                {
                    Console.WriteLine("Enter the first value:");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second value:");
                    y = Convert.ToDouble(Console.ReadLine());
                    amount = x - y;
                    Console.WriteLine("Your result  =   " + amount);
                    Console.WriteLine("To exit press Escape, and any other key to continue");
                }
                
                else if (output == '*')
                {
                    Console.WriteLine("Enter the first value:");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second value:");
                    y = Convert.ToDouble(Console.ReadLine());
                    amount = x * y;
                    Console.WriteLine("Your result  =   " + amount);
                    Console.WriteLine("To exit press Escape, and any other key to continue");
                }

                else if (output == '/')
                {
                    Console.WriteLine("Enter the first value:");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second value:");
                    y = Convert.ToDouble(Console.ReadLine());
                    amount = x / y;
                    Console.WriteLine("Your result  =   " + amount);
                    Console.WriteLine("To exit press Escape, and any other key to continue");
                }

                else
                {
                    Console.WriteLine("Wow! Your input is incorrect");
                    Console.WriteLine("To exit press Escape, and any other key to continue");
                }

            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
