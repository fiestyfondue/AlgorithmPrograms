using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm problems");
            PermutateString permute = new PermutateString();
            string input = "abcd";
            PermutateString.PermuteRecursive(input, "");
            Console.WriteLine("-----------------------------");
            PermutateString.PermuteIterative(input, 0, input.Length - 1);

        }
    }
}
