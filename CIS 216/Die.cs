/*
 * Author: Christian Edge
 * Course: CIS 216 C# and .NET
 * Date: 1 May 2019
 * Project: Craps
 */

 /* The purpose of the Die class is to represent six-sided die rolls.
  */ 

using System;

class Die
{
    private Random random = new Random();

    //Returns random value between 1 and 6
    public int Roll()
    {
        return random.Next(1, 7);
    }
}

