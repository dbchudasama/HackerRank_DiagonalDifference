using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_DiagonalSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Value for the size of Matrix. For 3x3 enter 3, for 5x5 enter 5 and vice versa.
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            // Passing in our desired matrix. Equally can use method to auto generate random matrix.
            //var matrix = new int[,] { { 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 } }; 
            //Result.GetRandomSquareMatrix(); 

            for (int i = 0; i < n; i++)
            {
                // Enter matrix into console
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            Result.diagonalDifference(arr);
        }
    }
}

