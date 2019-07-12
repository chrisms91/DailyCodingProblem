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
	}
}
