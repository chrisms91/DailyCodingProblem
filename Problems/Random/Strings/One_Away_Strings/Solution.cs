using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Random.Strings.One_Away_Strings
{
	public class Solution
	{
		public static bool IsOneAway(string s1, string s2)
		{
			if ((s1 == s2) || (s1.Length == 1 && s2.Length == 1)) return true;

			if (s1.Length == s2.Length)
			{
				return IsOneAwaySameLength(s1, s2);
			}
			else if (s1.Length > s2.Length)
			{
				return IsOneAwayDiffLength(s1, s2);
			}
			else
			{
				return IsOneAwayDiffLength(s2, s1);
			}
		}

		private static bool IsOneAwaySameLength(string s1, string s2)
		{
			var differentAlready = false;
			for (var i = 0; i < s1.Length; i++)
			{
				if (s1[i] != s2[i])
				{
					if (differentAlready)
					{
						return false;
					}
					differentAlready = true;
				}
			}
			return true;
		}

		private static bool IsOneAwayDiffLength(string longer, string shorter)
		{
			if (longer.Length - shorter.Length > 1) return false;

			var ptl = 0;
			var pts = 0;
			var differentAlready = false;

			while (pts < shorter.Length)
			{
				if (longer[ptl] != shorter[pts])
				{
					if (differentAlready)
					{
						return false;
					}
					differentAlready = true;
					ptl++;
				}
				else
				{
					ptl++;
					pts++;
				}
			}
			return true;
		}
	}
}
