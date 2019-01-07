using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.cs
{
    class Program
    {
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }

        public static decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        public static decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            decimal x = 0, y = 0;
            bool flag = false;

            void GetX() {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                x = Convert.ToDecimal(input);
            }
            while (flag == false)
            {
                try
                {
                    flag = true;
                    GetX();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: Input was not a valid number.");
                    flag = false;
                }
            }
            flag = false;

            Console.Write("Enter an operation( + , - , * , or / ): ");
            string op = Console.ReadLine();

            void GetY()
            {
                Console.Write("Enter another number to complete the operation: ");
                string input = Console.ReadLine();
                y = Convert.ToDecimal(input);
            }
            while (flag == false)
            {
                try
                {
                    flag = true;
                    GetY();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: Input was not a valid number.");
                    flag = false;
                }
            }

            bool opflag; 
            do
            {
                switch (op)
                {
                    case "+":
                        Console.WriteLine($"{x} + {y} = {Add(x, y)}");
                        opflag = true;
                        break;
                    case "-":
                        Console.WriteLine($"{x} - {y} = {Subtract(x, y)}");
                        opflag = true;
                        break;
                    case "*":
                        Console.WriteLine($"{x} * {y} = {Multiply(x, y)}");
                        opflag = true;
                        break;
                    case "/":
                        Console.WriteLine($"{x} / {y} = {Divide(x, y)}");
                        opflag = true;
                        break;
                    default:
                        opflag = false;
                        Console.Write("Invalid operation. Please use add( + ), subtract( - ), multiply( * ), or divide( / ): ");
                        op = Console.ReadLine();
                        break;
                }
            } while (opflag == false);
        }
    }
}
