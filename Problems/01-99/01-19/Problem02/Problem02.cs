using System;
using System.Collections.Generic;
using System.Text;

namespace Problems._01_99._01_19.Problem02
{
	public class Problem02
	{

		// time: O(n)
		// space: O(n) to maintain arrays
		public static int[] ProductArrExceptSelf(int[] nums)
		{
			int length = nums.Length;
			int[] left = new int[length];
			int[] right = new int[length];
			int[] prod = new int[length];

			// calculate leftside
			int temp = 1;
			for (var i = 0; i < length; i++)
			{
				left[i] = temp;
				temp *= nums[i];
			}

			// calculate rightside
			temp = 1;
			for (var j = length - 1; j >= 0; j--)
			{
				right[j] = temp;
				temp *= nums[j];
			}

			// calculate production
			for (var k = 0; k < length; k++)
			{
				prod[k] = left[k] * right[k];
			}

			return prod;
		}

		// time: O(n^2)
		// space: O(n)
		public static int[] ProductArrExceptSelfBF(int[] nums)
		{
			int length = nums.Length;
			int[] result = new int[length];

			for (var i = 0; i < length; i++)
			{
				result[i] = 1;

				for (var j = 0; j < length; j++)
				{
					if (j != i)
					{
						result[i] *= nums[j];
					}
				}
			}
			return result;
		}
	}
}
