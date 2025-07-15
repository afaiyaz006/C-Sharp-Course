using System;

namespace ExerciseFour
{
    class Program
    {

        static void Main(string[] args)
        {
            var randomNumber = new Random();
            var number = randomNumber.Next(1, 10);

            Console.WriteLine("Guess a number between 1 to 100");
            for (int i = 0; i < 4; i += 1)
            {
                var guess = Console.ReadLine();
                if (Int32.Parse(guess) == number)
                {
                    Console.WriteLine("Correct");
                    return;
                }
                else
                {
                    Console.WriteLine("InCorrect");
                }
            }
            Console.WriteLine("No more attempts left.");
        }
    }

}