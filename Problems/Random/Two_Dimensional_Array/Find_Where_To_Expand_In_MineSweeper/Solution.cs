using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Random.Two_Dimensional_Array.Find_Where_To_Expand_In_MineSweeper
{
	public class Solution
	{
		public static int[,] Click(int[,] field, int numRows, int numCols, int givenI, int givenJ)
		{
			// return field if clicked value is not 0
			if (field[givenI, givenJ] != 0) return field;

			const int MARK = -2;
			var queue = new Queue<Tuple<int, int>>();

			// put it in the queue and mark it.
			queue.Enqueue(new Tuple<int, int>(givenI, givenJ));
			field[givenI, givenJ] = MARK;

			// BFS starts
			while (queue.Count != 0)
			{
				var currentLocation = queue.Dequeue();
				var currI = currentLocation.Item1;
				var currJ = currentLocation.Item2;

				for (var i = currI - 1; i <= currI + 1; i++)
				{
					for (var j = currJ - 1; j <= currJ + 1; j++)
					{
						// make sure indices are in the field range and process when its value is 0
						if (i >= 0 && i < numRows && j >= 0 && j < numCols && field[i, j] == 0)
						{
							queue.Enqueue(new Tuple<int, int>(i, j));
							field[i, j] = MARK;
						}
					}
				}
			}

			return field;
		}
	}
}
