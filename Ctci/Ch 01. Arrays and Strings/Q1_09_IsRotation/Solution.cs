using System.Text;

namespace Ctci.Ch01.ArraysandStrings.Q1_09_IsRotation
{
    public static class Solution
    {
        public static bool IsRotation(string s1, string s2)
        {
            var sb = new StringBuilder();
            sb.Append(s2).Append(s2);

            var concatStr = sb.ToString();

            return ctci.Library.AssortedMethods.IsSubString(concatStr, s1);
        }
    }
}
