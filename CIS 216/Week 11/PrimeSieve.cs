/*
 * Author: Christian Edge
 * Course: CIS 216 C# and .NET
 * Date: 21 Apr 2019
 * Project: Prime Sieve
 */

/* The purpose of Prime Sieve is use the Sieve of Eratosthenes to identify all the 
 * prime numbers between 1 and 100, and display them to the console.
 */

using System;
using System.Collections;

class PrimeSieve
{
   static void Main()
   {
        //Array of 100 bools set true
        BitArray IsPrime = new BitArray(100, true);

        //Prime numbers start at 2, these elements will be skipped in the loop
        IsPrime[0] = false; IsPrime[1] = false;
        
        //Nested looping structure
        for (int j = 2; j < IsPrime.Length; ++j)
        {
            for (int i = 2; i < IsPrime.Length; ++i)
            {
                if (IsPrime[i])
                {
                    if (i > j && i % j == 0)
                    {
                        IsPrime[i] = false;
                    }
                }
            }
        }
        

        //Here is an alternative method I found on the internet
        /*
        for (int i = 2; i < IsPrime.Length; ++i)
        {
            for (int j = (i * i); j < IsPrime.Length; j += i)
            {
                IsPrime[j] = false;
            }
        }
        */


        //Output
        for (int h = 0; h < IsPrime.Length; ++h)
        {
            if (IsPrime[h] == true)
            {
                Console.WriteLine($"{h} is a prime number");
            }
        }

    }//End of Main()
}//End of class PrimeSieve

