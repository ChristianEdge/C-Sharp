/*
 * Author: Christian Edge
 * Course: CIS 216 C# and .NET
 * Date: 1 May 2019
 * Project: Craps
 */

 /* The purpose of the Craps class is to play the game Craps. The program will roll
  * two dice for the player, calculate the value of point, and output the point
  * and a message.
  */

using System;
using System.Threading;

class Craps
{
    static void Main()
    {
        /* Instantiate two Die objects. Separately time their instantiation to 
         * ensure different seeds. */
        Die die_1 = new Die();
        Thread.Sleep(2000);
        Die die_2 = new Die();

       //Roll the dice and calculate the value of point
        int Point = die_1.Roll() + die_2.Roll();

        //Output the value of Point along with a message
        if (Point == 2 || Point == 3 || Point == 12)
        {
            Console.WriteLine($"You rolled a {Point}");
            Console.WriteLine("Craps - you lose");
        }
        else if (Point == 7 || Point == 11)
        {
            Console.WriteLine($"You rolled a {Point}");
            Console.WriteLine($"You win!");
        }
        else
        {
            Console.WriteLine($"You rolled a {Point}");
            Console.WriteLine($"Your point is {Point}. Roll again");
        }
    }//End of Main()

}//End of class Craps

