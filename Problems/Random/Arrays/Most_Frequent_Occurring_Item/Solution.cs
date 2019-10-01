using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Random.Arrays.Most_Frequent_Occurring_Item
{
	public class Solution
	{
		public static int? MostFrequent(int[] givenArray)
		{
			if (givenArray.Length == 0) return null;

			var hm = new Dictionary<int, int>();
			int? maxItem = null;
			var maxCount = -1;


			foreach (var key in givenArray)
			{
				if (hm.ContainsKey(key))
				{
					var currentValue = hm[key];
					currentValue++;
					hm[key] = currentValue;
				}
				else
				{
					hm.Add(key, 1);
				}

				if (hm[key] > maxCount)
				{
					maxCount = hm[key];
					maxItem = key;
				}
			}

			return maxItem;
		}
	}
}
