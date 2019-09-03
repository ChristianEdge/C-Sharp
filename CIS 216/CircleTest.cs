/*
 * Author: Christian Edge
 * Course: CIS 216 C# & .NET
 * Project: Circle Project
 * Date: 14 Feb 2019
 */

/* The purpose of this program is for a user to input the radius of a circle and
 * get back measurements about the circle: radius, diameter, circumference, and 
 * area.
 */


using System;


class CircleTest
{

    static void Main()
    {
        //instantiate a new object
        Circle myCircle = new Circle();


        //Output instructions to user
        //Store user input in variable
        Console.WriteLine("Enter a radius for your circle: ");

        float userRadius = float.Parse(Console.ReadLine());


        //Pass the user-defined value to the Circle object via set method
        myCircle.setRadius(userRadius);


        //Call the get methods, output the values to the user
        Console.WriteLine($"The radius of the circle is {myCircle.getRadius()}");
        Console.WriteLine($"The diameter of the circle is {myCircle.getDiameter()}");
        Console.WriteLine($"The circumference of the circle is {myCircle.getCircumference()}");
        Console.WriteLine($"The area of the circle is {myCircle.getArea()}");

    }//End of Main()

}//End of class CircleTest
