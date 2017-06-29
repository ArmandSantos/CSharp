using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class Calculator
    {
        
        public static void Compute()
        {
            Console.WriteLine("Welcome to the Calculator. \n\n");
            int input1 = FirstNumber();
            string operation = Operation();
            int input2 = SecondNumber();
            float answer;

            switch (operation)
            {
                case "-":
                    answer = input1 - input2;
                    break;
                case "+":
                    answer = input1 + input2;
                    break;
                case "/":
                    answer = input1 / input2;
                    break;
                case "*":
                    answer = input1 * input2;
                    break;
                default:
                    answer = 0;
                    break;
            }

            Console.WriteLine(input1.ToString() + " " + operation + " " + input2.ToString() + " = " + answer.ToString());
            Console.ReadLine();
        }
        public static int FirstNumber()
        {
            int num1;
            Console.Write("Please enter the first integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            return num1;
        }
        public static int SecondNumber()
        {
            int num2;
            Console.Write("Please enter the second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            return num2;
        }
        public static string Operation()
        {
            string operand;
            Console.Write("Please enter an operand (+, -, /, *): ");
            operand = Console.ReadLine();
            return operand;
        }
    }
}
