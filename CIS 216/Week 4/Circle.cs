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


class Circle
{
    //Declare instance variables
    private float radius;


    //Declare mutator method (a.k.a. set method)
    public void setRadius(float rad)
    {
        radius = rad;
    }


    //Declare accessor methods (a.k.a get methods)
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
        return (float) Math.Pow(radius, 2) * 3.14159f; 
    }
 
}//End of class Circle

