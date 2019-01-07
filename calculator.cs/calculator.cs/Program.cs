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
            Console.Write("Enter an number: ");
            decimal x = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter an operation( + , - , * , or / ): ");
            string op = Console.ReadLine();
            Console.Write("Enter another number to complete the operation: ");
            decimal y = Convert.ToDecimal(Console.ReadLine());

            bool opflag; 
            do
            {
                switch (op)
                {
                    case "+":
                        Console.WriteLine($"{x} + {y} = {Add(x, y)}");
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
