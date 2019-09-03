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


class Circle
{
    //Declare instance variable
    private float radius;


    //Constructor without parameters
    public Circle()
    {
        radius = 0;
    }

    //Constructor with one parameter
    public Circle(float r)
    {
        radius = r;
    }


    //Declare property (with accessor methods) for "radius"
    public float Radius
    {
        get
        {
            return radius;
        }

        set
        {
            radius = value;
        }
    }

    //Declare accessor methods
    public float getRadius()
    {
        return radius;
    }

    public float getDiameter()
    {
        return radius * 2.00f;
    }

    public float getCircumference()
    {
        return radius * 2.00f * 3.14159f;
    }

    public float getArea()
    {
        return (float)Math.Pow(radius, 2) * 3.14159f;
    }

}//End of class Circle

