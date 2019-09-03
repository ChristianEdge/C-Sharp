/*
 * Author: Chirstian Edge
 * Course: CIS 216 C# and .NET
 * Date: 7 May 2019
 * Project: Polymorphic Zoo
 */

using System;

//Derives from abstract class Animal
class Bear : Animal
{
    //Constructor
    public Bear()
    {

    }

    //Constructor with parameter
    public Bear(string m_name)
    {
        this.setName(m_name);
    }


    //One field of my choosing with accessor and mutator
    private int salmonCaught;

    public int getSalmonCaught()
    {
        return salmonCaught;
    }

    public void setSalmonCaught(int salmon)
    {
        salmonCaught = salmon;
    }


    //Overridden method from Animal class
    public override string makeSound()
    {
        return "bear growls";
    }

    //Overridden method from Animal class
    public override string ToString()
    {
        return $"The name is {this.getName()}, the class is {this.GetType()}. " +
            $"The special variable is number of salmon caught: {getSalmonCaught()}";
    }
}