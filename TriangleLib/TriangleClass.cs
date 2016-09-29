using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TriangleLib
{
    public class TriangleClass
    {
        double sideAB, sideBC, sideAC;
        TriangleClass(double x, double y, double z)
        {
            this.sideAB = x;
            this.sideBC = y;
            this.sideAC = z;
        }
        public static TriangleClass ThreeSides(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0 || (side1 + side2 <= side3) || (side1 + side3 <= side2) || (side3 + side2 <= side1))
                throw new ArgumentException();
            return new TriangleClass(side1, side2, side3);
        }
        public static TriangleClass TwoSidesAndAngle(double side1, double side2, double angle)
        {
            if (side1 <= 0 || side2 <= 0 || angle <= 0 || angle >= 180)
                throw new ArgumentException();
            double side3 = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2) - 2 * side1 * side2 * Math.Cos(angle * Math.PI / 180));
            return new TriangleClass(side1, side2, side3);
        }
        public static TriangleClass TwoAnglesAndSide(double angle1, double angle2, double side1)
        {
            if (side1 <= 0 || angle1 <= 0 || angle2 <= 0 || (angle1 + angle2 >= 180))
                throw new ArgumentException();
            double angle3 = (180 - angle1 - angle2) * Math.PI / 180;
            double side2 = side1 * Math.Sin(angle1 * Math.PI / 180) / Math.Sin(angle3);
            double side3 = side1 * Math.Sin(angle2 * Math.PI / 180) / Math.Sin(angle3);
            return new TriangleClass(side1, side2, side3);
        }
        public double TriangleSquare()
        {
            double p = (sideAB + sideAC + sideBC) / 2;
            return Math.Sqrt(p * (p - sideAB) * (p - sideAC) * (p - sideBC));
        }
    }
}
