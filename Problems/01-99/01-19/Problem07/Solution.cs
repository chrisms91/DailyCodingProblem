using System;
using System.Collections.Generic;
using System.Text;

namespace Problems._01_99._01_19.Problem07
{
	public class Solution
	{
		// time: o(2^n), space: o(1)?
		public static int GetCountDecoding(char[] digits, int length)
		{
			// basecase
			if (length == 0 || length == 1)
			{
				return 1;
			}

			int totalCount = 0;

			// if last char is not 0, add up to total count
			if (digits[length - 1] > '0')
			{
				totalCount = GetCountDecoding(digits, length - 1);
			}

			// if last two chars are decoded to single number means -> 10 <= n < 27, add up to total recursively..
			if (digits[length - 2] == '1' || (digits[length - 2] == '2' && digits[length - 1] < '7'))
			{
				totalCount += GetCountDecoding(digits, length - 2);
			}

			return totalCount;
		}

		// further optimization is possible using DP... (looks similar to fibonacci )
	}
}
