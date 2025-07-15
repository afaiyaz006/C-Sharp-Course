using System;

namespace ExerciseThree
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number = Console.ReadLine();
            Console.WriteLine("Factorial of " + Int32.Parse(number) + ": " + CalculateFactorial.Fact(Int32.Parse(number)));

        }
    }
    class CalculateFactorial
    {
        public static int Fact(int n) {
            if (n == 1)
            {
                return 1;

            }
            else
            {
                return n * Fact(n - 1);
            }
        }
    }
}