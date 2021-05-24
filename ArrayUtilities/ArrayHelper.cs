using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUtilities
{
    /// <summary>
    /// Utilities for arrays
    /// </summary>
    public static class ArrayHelper
    {
        /// <summary>
        /// Calculates the minimum element of an array
        /// if min cannot be determined(array is null or empty)
        /// return <see cref="int.MinValue"/>.
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The min value</returns>
        public static int Min(int[] array)
        {
            if (array is null || array.Length == 0)
            {
                Console.WriteLine("Nu am putu calcula minimul!");
                return int.MinValue;
            }
            else
            {
                int min = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }

                Console.WriteLine($"Minimul este {min}");

                return min;
            }

        }
    }
}
