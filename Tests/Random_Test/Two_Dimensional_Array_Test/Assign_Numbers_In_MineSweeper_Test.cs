using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Random.Two_Dimensional_Array.Assign_Numbers_In_MineSweeper;
namespace Tests.Random_Test.Two_Dimensional_Array_Test
{
	[TestClass]
	public class Assign_Numbers_In_MineSweeper_Test
	{
		[TestMethod]
		public void MineSweeper_ShouldReturnCorrectMatrix()
		{
			// Assign

			var bombs1 = new int[][]
			{
				new int[] { 0, 2 },
				new int[] { 2, 0 }
			};
			// mineSweeper(bombs1, 3, 3) should return:
			// [[0, 1, -1],
			//  [1, 2, 1],
			//  [-1, 1, 0]]

			var bombs2 = new int[][]
			{
				new int[] { 0, 0 },
				new int[] { 0, 1 },
				new int[] { 1, 2 }
			};
			// mineSweeper(bombs2, 3, 4) should return:
			// [[-1, -1, 2, 1],
			//  [2, 3, -1, 1],
			//  [0, 1, 1, 1]]

			var bombs3 = new int[][]
			{
				new int[] { 1, 1 },
				new int[] { 1, 2 },
				new int[] { 2, 2 },
				new int[] { 4, 3 }
			};
			// mineSweeper(bombs3, 5, 5) should return:
			// [[1, 2, 2, 1, 0],
			//  [1, -1, -1, 2, 0],
			//  [1, 3, -1, 2, 0],
			//  [0, 1, 2, 2, 1],
			//  [0, 0, 1, -1, 1]]


			// Act
			int[,] res1 = Solution.MineSweeper(bombs1, 3, 3);
			int[,] res2 = Solution.MineSweeper(bombs2, 3, 4);
			int[,] res3 = Solution.MineSweeper(bombs3, 5, 5);

			// Assert
			// Check additional output for this result..

			Solution.Print2DArray(res1);
			Solution.Print2DArray(res2);
			Solution.Print2DArray(res3);
		}
	}
}	
