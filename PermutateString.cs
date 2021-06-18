using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PermutateString
    {
        public static void PermuteRecursive(string inputWord, string ans)
        {
            if (inputWord.Length == 0)
            {
                Console.WriteLine(ans + " ");
                return;
            }
            for (int i = 0; i < inputWord.Length; i++)
            {
                char ch = inputWord[i];
                string leftSubStr = inputWord.Substring(0, i);
                string rightSubStr = inputWord.Substring(i + 1);
                string rest = leftSubStr + rightSubStr;
                PermuteRecursive(rest, ans + ch);
            }
        }
        
        /// <param name="inputword">input sting</param>
        /// <param name="l">left index</param>
        /// <param name="r">right index</param>
        public static void PermuteIterative(string inputword, int l, int r)   // Permutation of string using iterative method 
        {
            if (l == r)
                Console.WriteLine(inputword);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    inputword = Swap(inputword, l, i);
                    PermuteIterative(inputword, l + 1, r);
                    inputword = Swap(inputword, l, i);
                }
            }
        }
      
        
        private static string Swap(string inputword, int l, int i)    // swapping method  string
        {
            char temp;
            char[] charArray = inputword.ToCharArray();
            temp = charArray[l];
            charArray[l] = charArray[i];
            charArray[i] = temp;
            string s = new string(charArray);
            return s;
        }

    }
}
