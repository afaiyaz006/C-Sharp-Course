using System;
using System.Collections;

namespace ExerciseFive
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList friendList = new ArrayList();
            while (true)
            {
                var friendName = Console.ReadLine();
                if (friendName == "")
                {
                    break;
                }
                friendList.Add(friendName);

            }
            var total = friendList.Count;
            if (friendList.Count >= 3)
            {
                Console.WriteLine(friendList[0] + " " + friendList[1] + " & " + (total-2) + " others.");

            }
            else if (friendList.Count == 2)
            {
                Console.WriteLine(friendList[0] + " & " + friendList[1]);
            }
            else
            {
                Console.WriteLine(friendList[0]);
            }

        }
    }
}