using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 0;
            for (int i = 1; i <= 100; i += 1)
            {
                if (i % 3 == 0)
                {
                    total += 1;
                }
            }
            Console.WriteLine("Number divisible by 3 are: " + total);
        }
    }
}
