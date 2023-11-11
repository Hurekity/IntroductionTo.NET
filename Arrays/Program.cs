// #define ARRAYS_1
// #define ARRAYS_2
#define JAGGED_ARRAYS


///////////////////////////////////
/* Зубчатый массив - массив одномерных массивов.
 * Его структура очень напоминает двухмерный динамический массив в с++.
 
 *//////////////////////////////////
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
// dynamic arrays only
// массивы это объекты в С#, кроме множества значений хранят некоторые свои св-ва.
// и обладают некоторым поведением.
// бывают одномерные, многомерные, зубчатые массивы.
namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ARRAYS_1
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random(0);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100, 200);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine($"Array sum: {arr.Sum()}");
            Console.WriteLine($"Array avg: {arr.Average()}");
            Console.WriteLine($"Array min: {arr.Min()}");
            Console.WriteLine($"Array max: {arr.Max()}");
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

#endif

#if ARRAYS_2
            Random rand = new Random(0);

            Console.Write("Write string amount: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write string elements amount: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[rows, cols];
            Console.WriteLine($"Amount of измерений array: {arr.Rank}");
            Console.WriteLine($"Amount of string in array: {arr.GetLength(0)}");
            Console.WriteLine($"Amount of string elemetns in array: {arr.GetLength(1)}");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(100);
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {arr.Cast<int>().Sum()}");
            // cast modify 2-х мерный массив в 1-мерный
            Console.WriteLine($"Avg: {arr.Cast<int>().Average()}");
            Console.WriteLine($"Min: {arr.Cast<int>().Min()}");
            Console.WriteLine($"Max: {arr.Cast<int>().Max()}"); 
#endif
            int[][] arr = new int[][]
            {
                new int[] { 0, 1, 1, 2 },
                new int[] { 3, 5, 8 },
                new int[] { 13, 21 },
                new int[] { 34, 55, 89 }
            };
            for (int i = 0;i<arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");   
                }
                Console.WriteLine();    
            }
            
        }
    }
}
