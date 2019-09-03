/*
 * Author: Christian Edge
 * Date: 03 March 2019
 * Project: Point Project
 * Course: CIS 216 C# & .NET
 */

/* The purpose of this program is for a user to provide X and Y coordinates for a
 * point, and to output a string that specifies which quadrant that point exists in,
 * based on the Cartesian coordinate system. The program will also output a quadrant 
 * location for a program-defined point. The users' point is named "Ginger" and the
 * program's point is named "Fred". 
 */

using System;

class PointTest
{
    static void Main()
    {
        //Output instructions
        Console.WriteLine("Welcom to the Cartesian Coordinate Quadrant Finder " + 
            "program. \n" + "You enter coordinates for a point and discover which " +
            "quadrant it is located in. \n" + "Your point is named 'Ginger'. \n" +
            "The program will generate its own point named 'Fred'. \n" + 
            "Please use real number values for your coordinates. (Ex: -6, 4)");
        Console.WriteLine();


        //Accept user input and assign to variables
        Console.WriteLine("Please enter the X value for your coordinate: ");
        double userX = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the Y value for your coordinate: ");
        double userY = double.Parse(Console.ReadLine());

        Console.WriteLine();



        //instantiate new objects
        Point Fred = new Point();
        Point Ginger = new Point(userX, userY);



        /* Instantiate random object to generate random values for program-generated
         * X and Y coordinates */
        Random random = new Random();

        //Use mutator methods to assign value to program-generated point
        Fred.setX(random.Next(-10, 10));
        Fred.setY(random.Next(-10, 10));



        //Call getLocation() on the objects and output data 
        Console.WriteLine("Ginger's coordinates are X: {0}, Y: {1}", userX, userY);
        Console.WriteLine("Your" + Ginger.getLocation());
        Console.WriteLine();
        Console.WriteLine("Fred's coordinates are X: {0}, Y: {1}", Fred.getX(), Fred.getY());
        Console.WriteLine("The program-generated" + Fred.getLocation());
        
    }

}//End of class PointTest

