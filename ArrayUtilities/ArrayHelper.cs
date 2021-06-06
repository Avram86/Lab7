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

            int[] result = Clone(array);

            int intermediary = 0;

            bool areElementsOrdered;
            do
            {
                areElementsOrdered = true;

                for (int i = 0; i < result.Length - 1; i++)
                {
                    bool isSwapNeeded = true;

                    switch (sortDirection)
                    {
                        case SortDirection.Descending:
                            isSwapNeeded = result[i] < result[i + 1];
                            break;

                        case SortDirection.Ascending:
                            isSwapNeeded = result[i] > result[i + 1];
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

            return result;
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

        /// <summary>
        /// Prints an array to the console
        /// </summary>
        /// <param name="array"></param>
        /// <param name="label"></param>
        public static void Print(long[] array, string label)
        {
            string labelToPrint = label ?? "Array";

            string arrayElementsList = string.Join(", ", array ?? new long[0]);

            Console.WriteLine($"{labelToPrint}=[{arrayElementsList}]");
        }

        /// <summary>
        /// Clones the original array into a new one, copying the elements
        /// </summary>
        /// <param name="array">the original array</param>
        /// <returns>A clone</returns>
        public static int[] Clone(int[] array)
        {
            if (array is null || array.Length == 0)
            {
                return new int[0];
            }

            int[] clone = new int[array.Length];
            for (int i = 0; i < clone.Length; i++)
            {
                clone[i] = array[i];
            }

            return clone;
        }

        /// <summary>
        /// Sorts the array using the selection sort
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sortDirection"></param>
        /// <returns></returns>
        public static int[] SelectionSort(int[] array, SortDirection sortDirection)
        {
            int[] result = Clone(array);

            for (int i = 0; i < result.Length - 1; i++)
            {
                //la fiecare pas, trebuie returnat min din subsirul ramas
                for (int j = i + 1; j < result.Length; j++)
                {
                    bool isswapNeeded;

                    switch (sortDirection)
                    {
                        case SortDirection.Descending:
                            isswapNeeded = result[i] < result[i + 1];
                            break;

                        case SortDirection.Ascending:
                        default:
                            isswapNeeded = result[i] > result[i + 1];
                            break;
                    }
                    if (isswapNeeded)
                    {
                        int temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Calculates the fibonacci sequence till n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long[] Fibonacci(int n)
        {
            if (n < 0)
            {
                return new long[0];
            }

            if (n == 0)
            {
                return new long[] { 0 };
            }

            if (n == 1)
            {
                return new long[] { 0, 1 };
            }

            //n>=2
            long[] result = new long[n + 1];
            result[0] = 0;
            result[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                result[i] = result[i - 1] + result[i - 1];
            }

            return result;

        }

        /// <summary>
        /// ciurul lui Eratostene
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] PrimesEratostene(int n)
        {
            if (n <= 1)
            {
                return new int[0];
            }

            //n>=2
            bool[] isCut = new bool[n + 1];
            int countPrimes = 0;
            isCut[0] = true;
            isCut[1] = true;

            for (int i = 2; i < isCut.Length; i++)
            {
                if (isCut[i] == true)
                {
                    continue;
                }
                else
                {
                    //"i" is prime
                    countPrimes++;

                    //cut multiples of i
                    for (int factor = 2; i * factor <= n; factor++)
                    {
                        isCut[i * factor] = true;
                    }
                }
            }

            int[] result = new int[countPrimes];

            for (int i = 0, indexPrime = 0; i < isCut.Length; i++)
            {
                if (!isCut[i])
                {
                    result[indexPrime] = i;
                    indexPrime++;
                }
            }

            return result;
        }

        public static int[,] ReadMatrix(string label)
        {
            label = label ?? "Matrix";

            int rowsCount = ConsoleHelper.ReadNumber($"{label} no of rows", 3, 3);
            int columnsCount = ConsoleHelper.ReadNumber($"{label} no of columns", 3, 3);

            int[,] matrix = new int[rowsCount, columnsCount];

            for (int row = 0; row < rowsCount; row++)
            {
                for (int col = 0; col < columnsCount; col++)
                {
                    int element = ConsoleHelper.ReadNumber($"element[{row},{col}] ", 3, 0);
                    matrix[row, col] = element;
                }
            }

            return matrix;
        }

        public static void PrintMatrix(string label, int[,] matrix)
        {
            Console.WriteLine(label ?? "Matrix");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //6 spatii goale dupa cifra
                    Console.Write($"{matrix[i, j],6}");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Prints the mainDiagonal of the matrix
        /// </summary>
        /// <param name="matrix">The given matrix</param>
        public static void PrintMainDiagonal(int[,] matrix)
        {
            if (matrix is null)
            {
                Console.WriteLine("Matrix is null, no main diagonal to print!");
                return;
            }

            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            int min = Math.Min(row, column);

            Console.WriteLine("Main diagonal elements are:");
            for (int i = 0; i < min; i++)
            {
                Console.Write($"{matrix[i, i],6}, ");
            }
        }

        /// <summary>
        /// returns the maindiagonal of a matrix in form of an array
        /// </summary>
        /// <param name="matrix">the matrix</param>
        /// <returns>an array</returns>
        public static int[] MainDiagonalAsArray(int[,] matrix)
        {
            if (matrix is null)
            {
                return new int[0];
            }

            
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            int min = Math.Min(row, column);

            int[] mainDiagonal = new int[min];

            Console.WriteLine("Main diagonal elements are:");
            for (int i = 0; i < min; i++)
            {
                mainDiagonal[i] = matrix[i, i];
            }

            return mainDiagonal;
        }

        /// <summary>
        /// Returns the sum of 2 matrices
        /// </summary>
        /// <param name="matrix1">The first matrix to be added</param>
        /// <param name="matrix2">The second matrix to be added</param>
        /// <returns>A new matrix of integers</returns>
        public static int[,] SumOf2Matrices(int[,] matrix1, int[,] matrix2)
        {
            if(matrix1 is null || matrix2 is null)
            {
                return new int[0, 0];
            }

            int row1 = matrix1.GetLength(0);
            int col1 = matrix1.GetLength(1);

            int row2 = matrix2.GetLength(0);
            int col2 = matrix2.GetLength(1);

            if(row1!=row2 || col1 != col2)
            {
                return new int[0, 0];
            }

            int[,] sum = new int[row1, col1];

            for(int i = 0; i < row1; i++)
            {
                for(int j = 0; j < col1; j++)
                {
                    sum[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return sum;
        }

        public static void PrintAMatrix(string label, int[,] matrix)
        {
            if(matrix is null)
            {
                Console.WriteLine("Not given a matrix to print");
            }

            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            Console.WriteLine(label);
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write($"{matrix[i,j],6}");
                }
                Console.WriteLine();
            }
        }
    }
}

