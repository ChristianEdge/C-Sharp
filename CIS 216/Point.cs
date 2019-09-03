/*
 * Author: Christian Edge
 * Date: 03 March 2019
 * Project: Point Project
 * Course: CIS 216 C# & .NET
 */

/* The purpose of this program is for a user to provide X and Y coordinates for a
 * point, and to output a string that specifies which quadrant that point exists in,
 * based on the Cartesian coordinate system. The program will also output a quadrant 
 * location for a program-defined point.
 */

using System;

class Point
{
    //declare instance variables, members #1 & #2
    private double x;
    private double y;



    //no parameters constructor, member #3
    public Point()
    {
        //Use setters setX() & setY()
    }



    //two parameters constructor, member #4
    //use this to pass user-based arguments
    public Point (double X, double Y)
    {
        x = X;
        y = Y;
    }


    
    //mutator methods, members #5 & #6
    public void setX(double X)
    {
        x = X;
    }

    public void setY(double Y)
    {
        y = Y;
    }
    


    //accessor methods, members #7 & #8
    public double getX()
    {
        return x;
    }

    public double getY()
    {
        return y;
    }



    /* This method gets the quadrant location of the point
     * Assume neither coord X nor coord Y will be equal to zero,
     * except when they are both equal to 0.
     * getLocation() must return a string.
     * This is member #9.
     */
    public string getLocation()
    {
        //Nullable int to have value returned in output string
        int? quadrant = null;

        string statement;

        if (x > 0 && y > 0)
        {
            quadrant = 1;
        }

        else if (x < 0 && y > 0)
        {
            quadrant = 2;
        }

        else if (x < 0 && y < 0)
        {
            quadrant = 3;
        }

        else if (x > 0 && y < 0)
        {
            quadrant = 4;
        }

        else if (x == 0 && y == 0)
        {
            return " point is located at origin (0, 0)";
        }

        statement = $" point is located in quadrant {quadrant}";

        return statement;

    }//end of getLocation()

}//End of class Point

