using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace HackerRank_DiagonalSum
{
    public class Result
    {
        const int MATRIX_MIN_SIZE = 2;
        const int MATRIX_MAX_SIZE = 5;

        const int MIN_VALUE = -100;
        const int MAX_VALUE = 100;


        /// <summary>
        /// Additional method written to auto generate random empty matrix (Based on constants set for size)
        /// </summary>
        /// <returns>Randomly Generated Matrix</returns>
        public static int[,] GetRandomSquareMatrix()
        {
            var random = new Random();
            var size = random.Next(MATRIX_MIN_SIZE, MATRIX_MAX_SIZE + 1);
            var matrix = new int[size, size];

            FillUpMatrix(matrix);

            return matrix;
        }


        /// <summary>
        /// If GetRandomSquareMatrix() is called then this method is used inside it to populate the matrix with the auto generated values 
        /// </summary>
        /// <param name="matrix"></param>
        static void FillUpMatrix(int[,] matrix)
        {
            var random = new Random();
            var size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(MIN_VALUE, MAX_VALUE + 1);
                }
            }
        }


        /// <summary>
        /// Method to fetch Diagonal Values from matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="primaryDiagonalValues"></param>
        /// <param name="secondaryDiagonalValues"></param>
        public static void GetDiagonalValues(int[,] matrix, out IEnumerable<int> primaryDiagonalValues, out IEnumerable<int> secondaryDiagonalValues)
        {
            var size = matrix.GetLength(0);

            //LINQ!
            primaryDiagonalValues = Enumerable.Range(0, size).Select(v => matrix[v, v]);
            secondaryDiagonalValues = Enumerable.Range(0, size).Select(v => matrix[v, size - v - 1]);
        }



        /// <summary>
        /// Displays the auto generated or passed in matrix
        /// </summary>
        /// <param name="matrix"></param>
        public static void DisplayMatrix(int[,] matrix)
        {
            var size = matrix.GetLength(0);
            
            //Looping over 2 dimensional array
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    //Returning new string representation of the matrix with padding so it is right aligned on displayed
                    Write(matrix[i, j].ToString().PadLeft(5, ' '));
                }

                WriteLine();
            }
        }


        //  *
        // * Complete the 'diagonalDifference' function below.
        // *
        // * The function is expected to return an INTEGER.
        // * The function accepts 2D_INTEGER_ARRAY arr as parameter.
        // */
        public static int diagonalDifference(int[,] matrix)
        {
            IEnumerable<int> pDiagonalValues;
            IEnumerable<int> sDiagonalValues;

            GetDiagonalValues(matrix, out pDiagonalValues, out sDiagonalValues);

            //Calculate the absolute Sum of matrix diagonals - LINQ!
            var absoluteDifference = Math.Abs(pDiagonalValues.Zip(sDiagonalValues, (x, y) => x - y).Sum());

            WriteLine("Matrix Generated");
            WriteLine("================");
            WriteLine();
            DisplayMatrix(matrix);
            WriteLine();
            WriteLine($"Primary diagonal    : { string.Join(", ", pDiagonalValues) }");
            WriteLine($"Secondary diagonal  : { string.Join(", ", sDiagonalValues) }");
            WriteLine($"Absolute difference : { absoluteDifference }");

            return absoluteDifference;
        }

    }
}