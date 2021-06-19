using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BubbleSort
    {
        internal static void Sorting()
        {
            int[] array = { 20, 14, 3, 7, 2 };
            Console.WriteLine("Unsorted array");
            Display(array);
            int[] sortedArray = Sort(array);
            Console.WriteLine("Sorted array");
            Display(sortedArray);
        }
        
        private static int[] Sort(int[] array)                // sorting an array using bubble sort, returns a sorted array
        {
            
            for (int i = 0; i < array.Length; i++)          //FirstIteration
            {
                //flag to check if any swapping is done.
                int flag = 0;
                for (int j = 0; j < array.Length - 1 - i; j++)       //Second Iteration
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j]= array[j+ 1];
                        array[j + 1] = temp;
                        flag++;
                    }
                }
                //if no swap is done then array is sorted.
                if (flag == 0)
                {
                    break;
                }
            }
            return array;
        }
        
        /// <param name="array"></param>
        private static void Display(int[] array)     // method to display an array 
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
