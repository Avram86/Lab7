using System;
using ArrayUtilities;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sir1 = { 1, 2, 3 };
            int[] sir2 = { 9, 8 };

            int[][] result = ArrayHelper.CartesianProduct(sir1, sir2);
            ArrayHelper.PrintJaggedArray("Cartesian product", result);
            //return;

            int[,] matrix = ArrayHelper.ReadMatrix("matrix1");
            ArrayHelper.PrintMatrix("matrix1" ,matrix);

            //ArrayHelper.PrintMainDiagonal
            int[] mainDiagonal = ArrayHelper.MainDiagonalAsArray(matrix);
            ArrayHelper.Print(mainDiagonal, "MainDiagonal is: ");

            //ArrayHelper.SumOf2Matrices
            int[,] matrix2 = ArrayHelper.ReadMatrix("matrix2");
            ArrayHelper.PrintMatrix("matrix2", matrix2);
            int[,] sum = ArrayHelper.SumOf2Matrices(matrix, matrix2);
            ArrayHelper.PrintAMatrix("The sum of the 2 matrices is: " ,sum);

            //Arrayhelper.ProductOf2Matrices
            int[,] prod = ArrayHelper.ProductOf2Matrices(matrix, matrix2);
            ArrayHelper.PrintAMatrix("Product of two matrices", prod);

            //int[] array = { 2, -10, 5, -100, 2};

            //int[] elementsAsc = ArrayHelper.SelectionSort(array, SortDirection.Ascending);
            //ArrayHelper.Print( elementsAsc, "elements ascending");

            //int[] elementsDesc = ArrayHelper.SelectionSort(array, SortDirection.Descending);
            //ArrayHelper.Print(elementsDesc, "elements descending");

            //long[] fibo = ArrayHelper.Fibonacci(12);
            //ArrayHelper.Print( fibo, "Fibonacci");

            //int[] primes = ArrayHelper.PrimesEratostene(10);
            //ArrayHelper.Print(primes, "Primes");

        }
        
        private static string ReadFromKeybooard(string label)
        {
            Console.Write(label);
            string text = Console.ReadLine();

            return string.IsNullOrWhiteSpace(text)?null:text;
            
        }

        static void Assignement4UsingIf()
        {
            string text = ReadFromKeybooard("Text=");
            if (string.IsNullOrWhiteSpace(text))
            {
                text = ReadFromKeybooard("Text(second attempt)");
            }

            if (string.IsNullOrWhiteSpace(text))
            {
                text = ReadFromKeybooard("Text(third attempt)");
            }

            if (string.IsNullOrWhiteSpace(text))
            {
                text = ReadFromKeybooard("Nu am continut");
            }
            else
            {
                Console.WriteLine(text);
            }
        }

        static void Assignement4UsingNullCoalesce()
        {
            string text = ReadFromKeybooard("Text=")
                ?? ReadFromKeybooard("Text(second attempt)")
                ?? ReadFromKeybooard("Text(third attempt)")
                ?? ReadFromKeybooard("Nu am continut");

            Console.WriteLine(text);
        }

 
    }
}
