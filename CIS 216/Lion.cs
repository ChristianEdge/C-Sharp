/*
 * Author: Chirstian Edge
 * Course: CIS 216 C# and .NET
 * Date: 7 May 2019
 * Project: Polymorphic Zoo
 */

using System;

//Derives from abstract class Animal
class Lion : Animal
{
    //Constructor
    public Lion()
    {

    }

    //Constructor with parameter
    public Lion(string name)
    {
        this.setName(name);
    }


    //One field of my choosing with accessor and mutator
    private int gazellesHugged;

    public int getGazellesHugged()
    {
        return gazellesHugged;
    }

    public void setGazellesHugged(int gazelles)
    {
        gazellesHugged = gazelles;
    }


    //Overridden method from Animal class
    public override string makeSound()
    {
        return "lion roars";
    }

    //Overridden method from Animal class
    public override string ToString()
    {
        return $"The name is {this.getName()}, the class is {this.GetType()}. " +
            $"The special variable is number of gazelles hugged: {getGazellesHugged()}";
    }
}

