using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    partial class Program
    {
        static void QuickSort(int[] inputArray, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex) return;
            int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
            QuickSort(inputArray, minIndex, pivot - 1);
            QuickSort(inputArray, pivot + 1, maxIndex);
            return;
        }
        static int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
        {
            int pivotIndex = minIndex - 1;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (inputArray[i] < inputArray[maxIndex])
                {
                    pivotIndex++;
                    Swap(inputArray, i, pivotIndex);
                }
            }
            pivotIndex++;
            Swap(inputArray, pivotIndex, maxIndex);
            return pivotIndex;
        }
        static void Swap(int[] inputArray, int leftValue, int rightValue)
        {
            int temp = inputArray[leftValue];
            inputArray[leftValue] = inputArray[rightValue];
            inputArray[rightValue] = temp;
        }
    }
}