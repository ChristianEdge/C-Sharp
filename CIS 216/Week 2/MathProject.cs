/*
 * Author: Christian Edge
 * Course: CIS 216 C# and .NET
 * Assignement: Math Project, Week 2 Homework
 * Date: Feb 1, 2019
 */

/* 
 * The purpose of this program is to input two integers and return
 * their product, quotient, sum, difference, and remainder.
 * Quotient will return a decimal number rather than a mixed number. 
 * Assume second integer will never be equal to 0.
 */

using System;


class MathProject
{
    static void Main()
    {
        //Output instructions to user
        //User prompted to input 2 integers, stored in variables
        //Console.ReadLine() returns a string, must convert to integer for math
        Console.WriteLine("Type your first integer then press ENTER: ");
            int UserInt1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Type your second integer then press ENTER: ");
            int UserInt2 = Convert.ToInt32(Console.ReadLine());



        //Perform calculations, store each result in a new variable
        int Sum = UserInt1 + UserInt2;
        int Difference = UserInt1 - UserInt2;
        int Product = UserInt1 * UserInt2;
        float Quotient = (float) UserInt1 / UserInt2;
            //Cast integers to floats for decimal division
        int Remainder = UserInt1 % UserInt2;



        //Output the data by accessing variables
        Console.WriteLine($"The sum of {UserInt1} and {UserInt2} " +
            $"is {Sum}.");

        Console.WriteLine($"The difference of {UserInt1} minus {UserInt2} " +
            $"is {Difference}.");

        Console.WriteLine($"The product of {UserInt1} times {UserInt2} " +
            $"is {Product}.");

        Console.WriteLine($"The quotient of {UserInt1} divided by {UserInt2} " +
            $"is {Quotient}.");

        Console.WriteLine($"The remainder of {UserInt1} divided by {UserInt2} " +
            $"is {Remainder}.");

    }//END MAIN()

}// END CLASS MathProject
