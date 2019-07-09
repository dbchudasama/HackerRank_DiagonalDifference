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
            // Passing in our desired matrix. Equally can use method to auto generate random matrix.
            var matrix = new int[,] { { 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 } }; //Result.GetRandomSquareMatrix(); 

            Result.diagonalDifference(matrix);
        }
    }
}

