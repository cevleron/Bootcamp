using System;

namespace ConsoleApp3
{
    partial class Program
    {
        //0, 2, -5, 5, 3, 7, 9, -1
        //0, 2, -5, 5, 3, 7, 9, -1
        static void Main(string[] args)
        {
            int[] arr = { 0, -5, 2, 3, 5, 9, -1, 7 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.Write($"Отсортированный массив {string.Join(", ", arr)}");
        }
        
    }
}