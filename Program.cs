using System;
using System.Diagnostics;

public class SortingComparison
{
    public static void Main(string[] args)
    {
        int[] arrBubbleSort = GenerateRandomArray(100); 
        int[] arrInsertionSort = new int[arrBubbleSort.Length];
        Array.Copy(arrBubbleSort, arrInsertionSort, arrBubbleSort.Length);

        Console.WriteLine("Bubble Sort");
        Console.WriteLine("Unsorted Array");
        PrintArray(arrBubbleSort);

        Stopwatch stopwatch = new Stopwatch();

       
        stopwatch.Start();
        BubbleSortAlgorithm(arrBubbleSort);
        stopwatch.Stop();
        Console.WriteLine("\nSorted Array:");
        PrintArray(arrBubbleSort);
        Console.WriteLine("\nTime taken for Bubble Sort: " + stopwatch.Elapsed);

        Console.WriteLine("\nInsertion Sort");
        Console.WriteLine("\nUnsorted Array:");
        PrintArray(arrInsertionSort);

       
        stopwatch.Restart();
        InsertionSortAlgorithm(arrInsertionSort);
        stopwatch.Stop();
        Console.WriteLine("\nSorted Array:");
        PrintArray(arrInsertionSort);
        Console.WriteLine("\nTime taken for Insertion Sort: " + stopwatch.Elapsed);
    }

    public static void BubbleSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            
            if (!swapped)
                break;
        }
    }

    public static void InsertionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    public static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(1, 1000); 
        }
        return arr;
    }

    public static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
