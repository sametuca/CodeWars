﻿namespace CodeWars.LatinSquares
{
    internal class Program
    {
        /*
         A latin square is an n × n array filled with the integers 1 to n, each occurring once in each row and column.

            Here are examples of latin squares of size 4 and 7:

            [[1, 4, 3, 2],      [[2, 3, 1, 7, 4, 6, 5], 
             [4, 3, 2, 1],       [7, 1, 6, 5, 2, 4, 3], 
             [3, 2, 1, 4],       [6, 7, 5, 4, 1, 3, 2], 
             [2, 1, 4, 3]]       [4, 5, 3, 2, 6, 1, 7], 
                                 [5, 6, 4, 3, 7, 2, 1], 
                                 [1, 2, 7, 6, 3, 5, 4], 
                                 [3, 4, 2, 1, 5, 7, 6]]
            Latin squares have many practical uses, for example in error-correcting-codes and the design of agricultural experiments. See https://en.wikipedia.org/wiki/Latin_square for more details. Sudoku is a special type of 9 x 9 latin square, with additional conditions.

            Task: Write a function that returns a latin square for any positive integer n.

            You might also enjoy Euler Squares.

            And please take a look at Latin Square Validator. (Since it's in beta, you won't get the expected number of points for solving it. But you can help get it approved by giving it a good rating, and then you will get the points once it is approved.)
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int[][] MakeLatinSquare(int n)
        {

            int[][] latinSquare = new int[n][];
            for (int i = 0; i < n; i++)
            {
                latinSquare[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    latinSquare[i][j] = (j + i) % n + 1;
                }
            }

            return latinSquare;
        }
    }
}