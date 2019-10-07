using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Random.Strings.Non_Repeating_Character
{
	public class Solution
	{
		public static char? NonRepeatingCharacter(string str)
		{
			if (str.Length == 0) return null;

			var dict = new Dictionary<char, int>();

			foreach (var chr in str)
			{
				if (dict.ContainsKey(chr))
				{
					var temp = dict[chr];
					temp++;
					dict[chr] = temp;
				}
				else
				{
					dict.Add(chr, 1);
				}
			}

			foreach (var chr in str)
			{
				if (dict[chr] == 1)
					return chr;
			}

			return null;
		}
	}
}
