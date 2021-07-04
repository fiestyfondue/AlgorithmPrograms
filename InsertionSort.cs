using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class InsertionSort
    {
        internal static void Sorting()
        {
            string[] array = {  "hello", "hi", "how", "is", "it", "Hanging"};
            Console.WriteLine("Unsorted Array");
            Display(array);
            Console.WriteLine("Sorted array....");
            string[] sortedArray = InsertSort(array);
            Display(sortedArray);
        }
        
        
        public static void Display(string[] Array)    // method to Display an array 
        {                                                   // <param name="sortedArray"></param>
            foreach (string item in Array)
            {
                Console.WriteLine(item);
            }
        }
        
        // <param name="array"> input array to be sorted</param>
       
        private static string[] InsertSort(string[] array)           // Method to perform Insertion Sort, returns an sorted array
        {
            for (int secondElement = 1; secondElement < array.Length; secondElement++)
            {
                string temp = array[secondElement];
                int prevElement = secondElement - 1;
                while (prevElement >= 0 && array[prevElement].CompareTo(temp) > 0)
                {
                    array[prevElement + 1] = array[prevElement];
                    prevElement--;
                }
                array[prevElement + 1] = temp;
            }
            return array;
        }
    }
}
