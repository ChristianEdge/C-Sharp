/*
 * Author: Chirstian Edge
 * Course: CIS 216 C# and .NET
 * Date: 7 May 2019
 * Project: Polymorphic Zoo
 */

 /* The purpose of the Polymorphic Zoo program that will handle the Animal base class
  * and its derived classes: Lion, Tiger, and Bear.
  */

using System;

 class PolymorphicZoo
{
    static void Main()
    {
        //Instantiate an object for each of the derived classes (Lion, Tiger, Bear)
        Lion Aslan = new Lion("Aslan");
        Tiger Tigger = new Tiger("Tigger");
        Bear Baloo = new Bear("Baloo");

        //Call member methods for each
        Aslan.setGazellesHugged(5);
        Tigger.setLasersChased(9);
        Baloo.setSalmonCaught(15);

        //Output number of Animal objects instantiated
        Console.WriteLine("There are " + $"{Animal.getAnimalCount()}" +
            " instantiated Animal objects.");
        Console.WriteLine();

        //Array of type Animal
        Animal[] myArray = new Animal[3];

        //Populate array
        myArray[0] = Aslan;
        myArray[1] = Tigger;
        myArray[2] = Baloo;

        //For loop will call overridden ToString() method for each animal in array
        for (int i = 0; i < Animal.getAnimalCount(); ++i)
        {
            Console.WriteLine($"{myArray[i].ToString()}");
            Console.WriteLine($"The animal's sound is {myArray[i].makeSound()}.");
            Console.WriteLine();
        }

    }
}

