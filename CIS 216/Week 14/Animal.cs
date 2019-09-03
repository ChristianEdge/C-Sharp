/*
 * Author: Chirstian Edge
 * Course: CIS 216 C# and .NET
 * Date: 7 May 2019
 * Project: Polymorphic Zoo
 */
 
 using System;

//Abstract base class
abstract class Animal
{
    //Protected fields
    protected string name;
    protected static int animalCount;

    //Constructor
    public Animal()
    {
        ++animalCount;
    }


    //Accessor and mutator methods
    public static int getAnimalCount()
    {
        return animalCount;
    }

    public void setAnimalCount(int m_animalCount)
    {
        animalCount = m_animalCount;
    }

    public string getName()
    {
        return name;
    }

    public void setName(string m_name)
    {
        this.name = m_name;
    }

    //override Object's ToString() method
    public override string ToString()
    {
        return base.ToString();
    }

    //Must override in derived classes
    public abstract string makeSound();
}

