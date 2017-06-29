using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exercise10
    {
        public static void BonusPoints()
        {
            Console.Write("Exercise10:  Write a program that applies bonus points to given scores in the range [1…9] by the following rules: \n" +
                          "- If the score is between 1 and 3, the program multiplies it by 10. \n" +
                          "- If the score is between 4 and 6, the program multiplies it by 100. \n" +
                          "- If the score is between 7 and 9, the program multiplies it by 1000. \n" +
                          "- If the score is 0 or more than 9, the program prints an error message. \n\n");
            Console.WriteLine("Please write a number between 1 and 9: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("The BONUS score is: " + (a * 10));
                    Console.ReadLine();
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("The BONUS score is: " + (a * 100));
                    Console.ReadLine();
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("The BONUS score is: " + (a * 1000));
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid Score!");
                    Console.ReadLine();
                    break;

            }
        }
    }
}

