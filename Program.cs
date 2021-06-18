using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 5, 0, 3, 36, 9 };
            
            Array.Sort(numbers);
            var index = BinarySearch(numbers, 3);
            
            Console.WriteLine(index);
            Console.ReadKey();
        }
            

        private static int LinearSearch(int[] array, int item)  //array and item_we_want_from_array stored
        {

            for (int i=0; i< array.Length; i++)
            {

                 if(array[i] == item)
                 {
                    return i;
                 }
            }
             return -1;
        }

        private static int BinarySearch(int[] array, int item )
        {
            int left = 0;
            int right = array.Length - 1;

            while(left<=right)
            {
                var middle = (left + right) / 2;  //Slicing the array in half

                if (array[middle] == item)
                    return middle;
                    

                if (item < array[middle])
                {
                    right = middle - 1;

                }
                else
                    left = middle + 1;
            }

            return -1;

        }   
    }
}
