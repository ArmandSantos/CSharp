using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exercise8
    {
        public static void ChooseIntDoubleOrString()
        {
            Console.Write("Exercise8: Write a program that, depending on the user’s choice, " +
                          "inputs int, double or string variable. If the variable is int or double, " +
                          "the program increases it by 1. If the variable is a string, the program appends * " +
                          "at the end. Print the result at the console. Use switch statement.\n\n");
            Console.WriteLine(
                "Please choose your input data type:\n 1 --> int\n 2 --> double\n 3 --> string\n ...and hit ENTER");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter your INTEGER number: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("The result is: {0}", (a + 1));
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Please enter your DOUBLE number: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("The result is: {0}", (b + 1));
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Please enter your STRING: ");
                    string c = Console.ReadLine();
                    Console.WriteLine("The result is: {0}", c + "*");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Invalid!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
