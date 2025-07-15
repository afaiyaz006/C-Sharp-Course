using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 0;
            while (true)
            {
                Console.Write("Enter a number: ");
                string instruction = Console.ReadLine();
                if (instruction == "ok")
                {
                    Console.WriteLine(total);
                    break;
                }
                else
                {
                    total += Int32.Parse(instruction);
                }
            }
        }
    }
}
