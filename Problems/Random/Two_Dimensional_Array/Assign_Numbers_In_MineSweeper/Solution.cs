using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Random.Two_Dimensional_Array.Assign_Numbers_In_MineSweeper
{
	public class Solution
	{
		public static int[,] MineSweeper(int[][] bombs, int numRows, int numCols)
		{
			// initialize 2d array for field
			int[,] field = new int[numRows,numCols];

			// iterate each bomb indices
			foreach (int[] bomb in bombs)
			{
				var rowIndex = bomb[0];
				var colIndex = bomb[1];

				// set bomb location to -1
				field[rowIndex, colIndex] = -1;

				for (int i = rowIndex - 1; i <= rowIndex + 1; i++)
				{
					for (int j = colIndex - 1; j <= colIndex + 1; j++)
					{
						if (i >= 0 && i < numRows && j >= 0 && j < numCols && field[i, j] != -1)
						{
							field[i, j] += 1;
						}
					}
				}
			}

			return field;
		}

		public static void Print2DArray<T>(T[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
