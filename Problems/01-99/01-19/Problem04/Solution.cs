using System;
using System.Collections.Generic;
using System.Text;

namespace Problems._01_99._01_19.Problem04
{
	public class Solution
	{
		// time o(n), space o(n)
		public static int FindFirstMissingPositive(int[] nums)
		{
			var hs = new HashSet<int>();
			int result;

			if (nums.Length == 0 || nums == null)
			{
				return 1;
			}

			// build hashset with positive intergers in given array
			foreach (var num in nums)
			{
				if (num > 0)
				{
					hs.Add(num);
				}
			}

			// iterate all positive integers to find minimum missing integer
			for (result = 1; result <= Int32.MaxValue; result++)
			{
				if (!hs.Contains(result))
				{
					break;
				}
			}
			return result;
		}

		// time: o(n), space o(1)
		public static int FindFirstMissingPositiveLinear(int[] nums)
		{
			int idx = 0;

			// move all positive numbers to the left, markt the length of active part by idx
			foreach (var n in nums)
			{
				if (n > 0)
				{
					nums[idx++] = n;
				}
			}

			// the range of result will be [1, idx+1]
			for (int i = 0; i < idx; i++)
			{
				int j = Math.Abs(nums[i]) - 1;
				// 0 < nums[j] < idx, means j+1 exists, mark visited by making its value negative
				if(j < idx && nums[j] > 0)
				{
					nums[j] *= -1;
				}
			}

			for (int i = 0; i < idx; i++)
			{
				if (nums[i] > 0)
				{
					return i + 1;
				}
			}

			return idx + 1;
		}
	}
}
