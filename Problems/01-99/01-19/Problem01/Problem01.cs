using System;
using System.Collections.Generic;
using System.Text;

namespace Problems._01_99._01_19
{
	public class Problem01
	{
		public static bool ContainsTwoSum(int[] nums, int sum)
		{
			var hashSet = new HashSet<int>();

			foreach (var num in nums)
			{
				var diff = sum - num;
				if (!hashSet.Contains(diff))
				{
					hashSet.Add(num);
				}
				else
				{
					return true;
				}
			}
			return false;
		}
	}
}
