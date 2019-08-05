using System;
namespace Ctci.Ch_01._Arrays_and_Strings.Q1_05_One_Away
{
    public class Solution
    {
        // Time: O(n)
        // Space: O(1)
        public static bool IsOneAway(string str1, string str2)
        {
            var str1Length = str1.Length;
            var str2Length = str2.Length;

            if (str1Length == str2Length)
            {
                // check for edit
                return IsOneEditAway(str1, str2);
            }
            else if (str1Length + 1 == str2Length)
            {
                // check for remove/add
                return IsOneInsertAway(str1, str2);
            }
            else if (str2Length + 1 == str1Length)
            {
                // check for remove/add
                return IsOneInsertAway(str2, str1);
            }
            return false;
        }

        private static bool IsOneEditAway(string str1, string str2)
        {
            var diffCharFound = false;
            for (var i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    if (diffCharFound)
                    {
                        return false;
                    }
                    diffCharFound = true;
                }
            }
            return true;
        }

        // assume str2's length is larger than str1
        private static bool IsOneInsertAway(string str1, string str2)
        {
            var index1 = 0;
            var index2 = 0;

            while (index1 < str1.Length && index2 < str2.Length)
            {
                if (str1[index1] != str2[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }
    }
}
