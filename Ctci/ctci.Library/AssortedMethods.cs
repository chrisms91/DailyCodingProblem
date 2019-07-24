using System;
using System.Collections.Generic;
using System.Text;

namespace Ctci.ctci.Library
{
	public class AssortedMethods
	{
		public static string SortString(string str)
		{
			char[] charArr = str.ToCharArray();
			Array.Sort(charArr);
			return new string(charArr);
		}
	}
}
