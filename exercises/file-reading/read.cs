using System;
using System.Collections;
using System.IO;
namespace ExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            try
            {
                StreamReader sr = new StreamReader("./input.txt");
                line = sr.ReadLine();
                var total = 0;
                while (line != null)
                {
                    Console.WriteLine(line);

                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] words = line.Split(" ");
                        if (words.Length > 0)
                        {
                            total += words.Length;
                        }
                    }
                }
                Console.WriteLine("Total words: " + total);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Invalid file");
            }


        }
    }
}