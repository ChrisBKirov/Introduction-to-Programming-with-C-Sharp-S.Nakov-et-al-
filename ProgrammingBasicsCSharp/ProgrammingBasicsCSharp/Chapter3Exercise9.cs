﻿///<summary> 
///TITLE              Intersections   Chapter3Exercise9.cs 
///    COMMENT
///        Objective: Write an expression that calculates
///                   whether a point: O(x, y) is inside a
///                   circle K((0, 0), 5) and outside a 
///                   rectangle ((-1, 1), (5, 5)) defined 
///                   by lower left and upper right corners. 
///            Input: -
///           Output: Point O(4.0, 0.9) is within the circle and out of the rectangle.
///</summary>
///<author>Chris B. Kirov</author>
///<datecreated>23.02.2016</datecreated>

using System;
using System.Text;

namespace ProgrammingBasicsCSharp
{
    class Chapter3Exercise9
    {
        static void Main()
        {
            // calculate point's distance from origin
            double coordinateX = 4.0d;
            double coordinateY = 0.9d;
            double distanceFromCenter = Math.Abs(Math.Sqrt(coordinateX * coordinateX + coordinateY * coordinateY));

            // circle parameters
            double circleRadius = 5.0d;

            // rectangle parameters
            double lowerLeftCornerX = -1.0d;
            double lowerLeftCornerY = 1.0d;
            double upperRightCornerX = 5.0d;
            double upperRightCornerY = 5.0d;

            // within circle ?
            if (distanceFromCenter <= circleRadius 
            // and outside vertical sides ?     
                && ((coordinateX < lowerLeftCornerX) || (coordinateX > upperRightCornerX) 
            // or outside horizontal sides ?
                 || (coordinateY < lowerLeftCornerY) || (coordinateY > upperRightCornerY)))
            {
                Console.WriteLine("Point O({0}, {1})  within the circle and out of the rectangle.", coordinateX, coordinateY);
            }
           
        }
    }
}
