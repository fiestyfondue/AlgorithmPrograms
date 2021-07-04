using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PrimeNo
    {
        public static void Print()
        {
            long range = 1000;
            Console.WriteLine("Prime Numbers");
            if (range <=1)
            {
                Console.WriteLine("Invalid number added");
            }
            else
            {
                for (int i=1; i<= range; i++)
                {
                    int counter = 0;
                    for (int j = i; j>=i; j--)
                    {
                        if(i%j==0)
                        {
                            counter++;
                        }
                    }
                    if(counter==2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
