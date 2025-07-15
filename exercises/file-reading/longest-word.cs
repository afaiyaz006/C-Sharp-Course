using System;
using System.Collections;
using System.IO;
namespace ExerciseTwo
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
                var maxLengthWord = 0;
                var thatWord = "";
                while (line != null)
                {
                    Console.WriteLine(line);

                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] words = line.Split(" ");
                        if (words.Length > 0)
                        {
                            for (int i = 0; i < words.Length; i += 1)
                            {
                                if (words[i].Length > maxLengthWord)
                                {
                                    maxLengthWord = words[i].Length;
                                    thatWord = words[i];
                                }
                            }

                        }
                    }
                }
                Console.WriteLine("Max length word: " + maxLengthWord+ " Word: "+thatWord);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Invalid file");
            }


        }
    }
}