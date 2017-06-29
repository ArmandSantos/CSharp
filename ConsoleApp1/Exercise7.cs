using System;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{
    class Exercise7
    {
        public static void Greatest()
        {
            Console.Write("Exercise7: Write a program that finds the greatest of given 5 numbers.\n\n");
            int [] numbers = new int[5];
            for (int ctr = 0; ctr < 5; ctr++)
            {
                int num = ctr + 1;
                Console.Write("\n Enter number" + num + ": ");

                numbers[ctr] = Convert.ToInt32(Console.ReadLine());

            }
            int greatest = numbers.Max();

            Console.WriteLine("\n\nThe Greatest Number is " + greatest);
            Console.ReadLine();

        }
    }
}