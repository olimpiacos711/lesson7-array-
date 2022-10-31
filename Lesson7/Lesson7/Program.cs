using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Program
    {

        static void bubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
        }

        static void printArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }

        static void selectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (array[j] < array[min_idx])
                        min_idx = j;
                int temp = array[min_idx];
                array[min_idx] = array[i];
                array[i] = temp;
            }
        }

        static void insertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 3, 4, 1 };
            Console.WriteLine("Array:");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine("\n");

            bubbleSort(arr);
            Console.WriteLine("Bubble sort");
            printArray(arr);
            Console.WriteLine();

            int[] arr2 = { 2, 5, 8, 1, 4 };
            Console.WriteLine("Array:");
            for (int i = 0; i < arr2.Length; ++i)
                Console.Write(arr2[i] + " ");
            Console.WriteLine("\n");

            selectionSort(arr2);
            Console.WriteLine("Selestion sort");
            printArray(arr2);
            Console.WriteLine();

            int[] arr3 = { 6, 1, 3, 9, 5 };
            Console.WriteLine("Array:");
            for (int i = 0; i < arr3.Length; ++i)
                Console.Write(arr3[i] + " ");
            Console.WriteLine("\n");

            insertionSort(arr3);
            Console.WriteLine("Insertion sort");
            printArray(arr3);
        }
    }
}
