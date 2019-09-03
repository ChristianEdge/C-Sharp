/*
 * Author: Chirstian Edge
 * Course: CIS 216 C# and .NET
 * Date: 7 May 2019
 * Project: Polymorphic Zoo
 */

using System;

//Derives from abstract class Animal
class Tiger : Animal
{
    //Constructor
    public Tiger()
    {

    }

    //Constructor with parameter
    public Tiger(string m_name)
    {
        this.setName(m_name);
    }


    //One field of my choosing with accessor and mutator
    private int lasersChased;

    public int getLasersChased()
    {
        return lasersChased;
    }

    public void setLasersChased(int numOfLasers)
    {
        lasersChased = numOfLasers;
    }


    //Overridden method from Animal class
    public override string makeSound()
    {
        return "tiger meows";
    }

    //Overridden method from Animal class
    public override string ToString()
    {
        return $"The name is {this.getName()}, the class is {this.GetType()}. " + 
            $"The special variable is number of lasers chased: {getLasersChased()}";
    }
}
