using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Random.Arrays.Common_Elements_In_Two_Sorted_Arrays
{
	public class Solution
	{
		// time: O(max(n, m))
		// space: O(n)
		public static int[] CommonElemetns(int[] array1, int[] array2)
		{
			if (array1.Length == 0 || array2.Length == 0) return null;

			var i = 0;
			var j = 0;
			var resultList = new List<int>();

			while (i < array1.Length && j < array2.Length)
			{
				if (array1[i] == array2[j])
				{
					resultList.Add(array1[i]);
					i++;
					j++;
				}
				else
				{
					if (array1[i] > array2[j])
						j++;
					else
						i++;
				}
			}
			return resultList.ToArray();
		}
	}
}
