/*
 * Author: Christian Edge
 * Course: CIS 216 C# & .NET
 * Project: Circle Project
 * Date: 03 March 2019
 */

/* 
 * The purpose of this program is for a user to input the radius of a circle and
 * get back measurements about the circle: radius, diameter, circumference, and 
 * area. The program will also construct its own circle and display its 
 * measurements to the user.
 */

using System;


class CircleTest
{

    static void Main()
    {
        //instantiate new objects
        Circle userCircle = new Circle(); //Constructor no parameters
        Circle myCircle = new Circle(7); //Constructor with a parameter

        //Output instructions to user
        Console.WriteLine("Enter a radius for your circle: ");

        /* Accept user input.
         * Pass the user-defined value to their Circle object (userCircle) via 
         * Radius property.
         */
        userCircle.Radius = float.Parse(Console.ReadLine());


        //Call the get methods, output the values to the user
        Console.WriteLine($"The radius of your circle is {userCircle.getRadius()}");
        Console.WriteLine($"The diameter of your circle is " +
            $"{userCircle.getDiameter()}");
        Console.WriteLine($"The circumference of your circle is " +
            $"{userCircle.getCircumference()}");
        Console.WriteLine($"The area of your circle is {userCircle.getArea()}");
        Console.WriteLine();
        Console.WriteLine($"The radius of my circle is {myCircle.getRadius()}");
        Console.WriteLine($"The diameter of my circle is {myCircle.getDiameter()}");
        Console.WriteLine($"The circumference of my circle is " +
            $"{myCircle.getCircumference()}");
        Console.WriteLine($"The area of my circle is {myCircle.getArea()}");
        Console.WriteLine();

    }//End of Main()

}//End of class CircleTest
