using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_CompareTriplets
{
    class Program
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {

            int aliceScore = 0;
            int bobScore = 0;

            for (int i = 0; i < a.Count; i++)
            { 
                if (a[i] > b[i])
                {
                    aliceScore++;
                }
                else if (a[i] < b[i])
                {
                    bobScore++;
                }
            }

            return new List<int> { aliceScore, bobScore };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Triplet for list a:");
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            Console.WriteLine("Please enter Triplet for list b:");
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            Console.WriteLine("Result is:");
            Console.WriteLine(String.Join(" ", "{", result, "}"));
        }
    }
}
