using System;
namespace Problems.Random.Two_Dimensional_Array.Rotate_90_InPlace
{
    public class Solution
    {
        public static int[, ] Rotate90(int[,] a, int n)
        {
            // Initialize new 2D array n * n
            int[,] rotated = new int[n, n];

            // Iterate 2d array and move values to the rotated location
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    rotated[i, j] = a[n - j - 1, i];
                }
            }

            return rotated;
        }

        public static void Rotate90Inplace(int[,] a, int n)
        {
            // iterate level n/2
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {
                    // store first value to temp and start swapping counter clockwise
                    var temp = a[i, j];

                    // assign left bottom to left top
                    a[i, j] = a[n - 1 - j, i];

                    // assign right bottom to left bottom
                    a[n - 1 - j, i] = a[n - 1 - j, n - 1 - i];

                    // assign right top to right bottom
                    a[n - 1 - j, n - 1 - i] = a[i, n - 1 - j];

                    // assign temp to right top
                    a[i, n - 1 - j] = temp;
                }
            }
        }
    }
}
