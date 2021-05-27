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

        /// <summary>
        /// Calculates the maximum element of an array
        /// if max cannot be determined(array is null or empty)
        /// return <see cref="int.MaxValue"/>.
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The min value</returns>
        public static int Max(int[] array)
        {
            if (array is null || array.Length == 0)
            {
                Console.WriteLine("Nu am putu calcula minimul!");
                return int.MaxValue;
            }
            else
            {
                int max = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }

                Console.WriteLine($"Minimul este {max}");

                return max;
            }
        }

        /// <summary>
        /// Sorts the array using the bubble sort algorithm
        /// </summary>
        /// <param name="array">The original array</param>
        /// <param name="sortDirection">The sort direction</param>
        /// <returns>The array having the sorted elements</returns>
        public static int[] BubbleSort(int[] array, SortDirection sortDirection)
        {
            //4, 3, 2, 1

            //pornim verificarea array-ului de la index 0
            //la fiecare pas:
            //          verificam daca elem de la indexul curent este mai mic
            //          decat elementul de la indexul urmator
            //          array[i]<array[i+1]
            //              Daca da: OK, mergi mai departe
            //              Daca NU: interschimbam elementele(array[i] trbuie sa devina array[i+1] si
            //                       array[i+1] trebuie sa devina array[i])
            //              du-te inapoi de la inceput siverifica din nou array-ul
            //NOTA: algoritmul se termina cand nu mai gasim perechi de elem care trebuie schimbate

            if(array==null || array.Length == 0)
            {
                return new int[0];
            }

            int intermediary;

            //bool didSwapOccured=true;

            //while(didSwapOccured)
            //{
            //    didSwapOccured = false;

            //    for (int i = 0; i < array.Length - 1; i++)
            //    {
            //        if (array[i] > array[i + 1])
            //        {
            //            intermediary = array[i];
            //            array[i] = array[i + 1];
            //            array[i + 1] = intermediary;
            //            didSwapOccured = true;
            //            break;
            //        }
                    
            //    }
            //}


            bool areElementsOrdered;
            do
            {
                areElementsOrdered = true;

                for (int i = 0; i < array.Length -1; i++)
                {
                    bool isSwapNeeded=true;

                    switch (sortDirection)
                    {
                        case SortDirection.Descending:
                            isSwapNeeded = array[i] < array[i + 1];
                            break;

                        case SortDirection.Ascending:
                            isSwapNeeded = array[i] > array[i + 1];
                            break;
                    }

                    if (isSwapNeeded)
                    {
                        intermediary = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = intermediary;
                        areElementsOrdered = false;
                        break;
                    }
                }
            } while (!areElementsOrdered);

            return array;
        }
      
        /// <summary>
        /// Prints the array to the console
        /// </summary>
        /// <param name="array"></param>
        /// <param name="label"></param>
        public static void Print(int[] array, string label)
        {
            string labelToPrint = label ?? "Array";

            string arrayElementsList = string.Join(", ", array ?? new int[0]);

            Console.WriteLine($"{labelToPrint}=[{arrayElementsList}]");
        }


    }
}
