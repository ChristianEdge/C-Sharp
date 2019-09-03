/* Author: Christian Edge
 * Course: CIS 216 C# & .NET
 * Date: 15 Apr 2019
 * Prject: MyArray Project
 * 
 * The purpose of this program is to generate an array with 10 random integers
 * between 1 and 100, use functions to find the minimum and maximum values of 
 * the array and their indices, and output that information to the user.   */

using System;

class MyArrays
{
    //This function takes an array and returns the highest value in the array
    //You get its index by passing a variable as a second parameter
    static int findMax(int[] array, out int index)
    {
        int Highest = array[0];
        index = 0;

        for (int i = 0; i < array.Length; ++i)
        {
            if (Highest < array[i])
            {
                Highest = array[i];
                index = i;
            }
        }
        return Highest;
    }

    //This function takes an array and returns the lowest value in the array
    //You get its index by passing a variable as a second parameter
    static int findMin(int[] array, out int index)
    {
        int Lowest = array[0];
        index = 0;

        for (int i = 0; i < array.Length; ++i)
        {
            if (Lowest > array[i])
            {
                Lowest = array[i];
                index = i;
            }
        }
        return Lowest;
    }

    static void Main()
    {
        //Instantiate objects, declare variables
        int[] myArray = new int[10];
        Random random = new Random();
        int Highest = -1, HighestIndex = -1,
            Lowest = -1, LowestIndex = -1;

        //Output introduction to user
        Console.WriteLine("Welcome to MyArrays Project. \n" +
            "The purpose of this program is for a Random Number Generator to " +
            "populate an array of ten indices \nwith random values between 1 and " +
            "100. It will then display the highest and lowest values and their\n" +
            "indices in the array.\n");

        //Assign random values to array
        for (int i = 0; i < (myArray.Length); ++i)
        {
            myArray[i] = random.Next(1, 100);
            Console.WriteLine($"Index {i} = {myArray[i]}");
        }

        //Call functions, assign variable values
        Highest = findMax(myArray, out HighestIndex);
        Lowest = findMin(myArray, out LowestIndex);
        
        //Output the data
        Console.WriteLine($"\nThe highest value is {Highest} and " +
            $"its index is {HighestIndex}. \nThe lowest value is {Lowest} and " +
            $"its index is {LowestIndex}.");
    }//End Main()
}//End class MyArrays

