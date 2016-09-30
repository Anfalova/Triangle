using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TriangleLib
{
    public class Triangle
    {
        double sideAB;
        double sideBC;
        double sideAC;
        Triangle(double x, double y, double z)
        {
            this.sideAB = x;
            this.sideBC = y;
            this.sideAC = z;
        }
        public static Triangle MakeFromThreeSides(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Side of triangle can't be null or negative.");
            if ((side1 + side2 <= side3) || (side1 + side3 <= side2) || (side3 + side2 <= side1))
                throw new ArgumentException("Triangle Rule is not satisfied.");
            return new Triangle(side1, side2, side3);
        }
        public static Triangle MakeFromTwoSidesAndAngle(double side1, double side2, double angle)
        {
            if (side1 <= 0 || side2 <= 0)
                throw new ArgumentException("Side of triangle can't be null or negative.");
             if (angle <= 0 )
                throw new ArgumentException("Angle of triangle can't be null or negative.");
             if (angle >= 180)
                throw new ArgumentException("Angle of triangle can't be  more than 180 degrees.");
            double side3 = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2) - 2 * side1 * side2 * Math.Cos(angle * Math.PI / 180));
            return new Triangle(side1, side2, side3);
        }
        public static Triangle MakeFromTwoAnglesAndSide(double angle1, double angle2, double side1)
        {
            if (side1 <= 0)
                throw new ArgumentException("Side of triangle can't be null or negative.");
            if  (angle1 <= 0 || angle2 <= 0)
                throw new ArgumentException("Angle of triangle can't be null or negative.");
            if (angle1 + angle2 >= 180)
                throw new ArgumentException("The sum of angles of a triangle must be less than 180 degrees.");
            double angle3 = (180 - angle1 - angle2) * Math.PI / 180;
            double side2 = side1 * Math.Sin(angle1 * Math.PI / 180) / Math.Sin(angle3);
            double side3 = side1 * Math.Sin(angle2 * Math.PI / 180) / Math.Sin(angle3);
            return new Triangle(side1, side2, side3);
        }
        public double GetArea()
        {
            double p = (sideAB + sideAC + sideBC) / 2;
            return Math.Sqrt(p * (p - sideAB) * (p - sideAC) * (p - sideBC));
        }
    }
}
