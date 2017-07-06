using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
			//Console.WriteLine("Choose which Program to run: ");
			//Console.WriteLine("1 - Calculator");
			//Console.WriteLine("2 - Exercise7");
			//Console.WriteLine("3 - Exercise8");
			//Console.WriteLine("4 - Exercise10");
			//Console.WriteLine("5 - Exercise11\n");

			//int a = int.Parse(Console.ReadLine());

			//switch (a)
			//{
			//    case 1: Calculator.Compute();
			//        break;
			//    case 2: Exercise7.Greatest();
			//        break;
			//    case 3: Exercise8.ChooseIntDoubleOrString();
			//        break;
			//    case 4: Exercise10.BonusPoints();
			//        break;
			//    case 5: Exercise11.NumbersConvertToWords();
			//        break;

			//    default:
			//        Console.WriteLine("Choose within the range!");
			//        Console.ReadLine();

			//            break;
			Satellite_SirNitz satellite = new Satellite_SirNitz();
			GPS gps = new GPS(satellite);

			satellite.Latitude = 50;
			satellite.Longitude = 60;

			Console.ReadLine();
		}

        }
    }
}
