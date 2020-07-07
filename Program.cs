using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Table_of_Powers
{
    class Program
    {
        static void Main(string[] args)
        {

            bool continueFlag = true;
            Console.WriteLine("Learn your squares and cubes!!!!!!!!!!!!!!!!");

            while (continueFlag)
            {
                Console.Write($"\nEnter an integer: ");
                int number = IntValidation(Console.ReadLine());

                Console.WriteLine($"\nNumber\t\tSquared\t\tCubed");
                Console.WriteLine($"=======\t\t=======\t\t=======");

                for (int i=1; i<=number; i++)
                {
                    Console.WriteLine(String.Format("{0,15}{1,15}{2,15}", i, i * i, i * i * i));
                }

                Console.Write($"\nContinue? (y/n): ");
                string cont = Console.ReadLine();
                cont = cont.ToLower();
                if (cont=="n")
                {
                    continueFlag = false;
                }
                else if (cont != "y") //bad input will exit
                {
                    Console.WriteLine("What you talking 'bout Willis? Exiting...");
                    continueFlag = false;
                }

            }
            Console.WriteLine($"\nByeeeeeeeeee!!!!!!!");

        }

        public static int IntValidation(string input)
        {
            int validIntOutput;
            while (!int.TryParse(input, out validIntOutput) || validIntOutput <= 0 || validIntOutput > 1290) //checks for non-ZERO positive integers as well as the max cube that will fit in an int
            {
                Console.WriteLine($"\nMust be a valid non-negative/non-ZERO integer, less than 1291.");
                Console.Write("Try again please: ");
                input = Console.ReadLine();
            }
            return validIntOutput;
        }

    }
}