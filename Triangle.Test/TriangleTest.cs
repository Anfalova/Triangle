using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Triangle.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Side of triangle can't be null or negative.")]
        public void MakeFromThreeSides_NullOrNegativeSide_ExceptionThrown()
        {
            double a = 0;
            double b = 5;
            double c = 5;
            TriangleLib.Triangle.MakeFromThreeSides(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Triangle Rule is not satisfied.")]
        public void MakeFromThreeSides_NoTriangle_ExceptionThrown()
        {
            double a = 1;
            double b = 1;
            double c = 100000;
            TriangleLib.Triangle.MakeFromThreeSides(a, b, c);
        }

        [TestMethod]
        public void GetArea_ThreeSides_AreaCalculatedCorrectly()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Assert.AreEqual(6, TriangleLib.Triangle.MakeFromThreeSides(a, b, c).GetArea());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Angle of triangle can't be null or negative.")]
        public void MakeFromTwoSidesAndAngle_NullOrNegativeAngle_ExceptionThrown()
        {
            double a = 5;
            double b = 5;
            double angle = -1;
            TriangleLib.Triangle.MakeFromTwoSidesAndAngle(a, b, angle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Angle of triangle can't be  more than 180 degrees.")]
        public void MakeFromTwoSidesAndAngle_MoreThan180Angle_ExceptionThrown()
        {
            double a = 5;
            double b = 5;
            double angle = 278;
            TriangleLib.Triangle.MakeFromTwoSidesAndAngle(a, b, angle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Side of triangle can't be null or negative.")]
        public void MakeFromTwoSidesAndAngle_NullOrNegativeSide_ExceptionThrown()
        {
            double a = 5;
            double b = -5;
            double angle = 90;
            TriangleLib.Triangle.MakeFromTwoSidesAndAngle(a, b, angle);
        }

        [TestMethod]
        public void GetArea_TwoSidesAndAngle_AreaCalculatedCorrectly()
        {
            double a = 3;
            double b = 4;
            double angle = 90;
            Assert.AreEqual(6, TriangleLib.Triangle.MakeFromTwoSidesAndAngle(a, b, angle).GetArea());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Side of triangle can't be null or negative.")]
        public void MakeFromTwoAnglesAndSide_NullOrNegativeSide_ExceptionThrown()
        {
            double a = -5;
            double angle1 = 45;
            double angle2 = 90;
            TriangleLib.Triangle.MakeFromTwoAnglesAndSide(angle1, angle2, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Angle of triangle can't be null or negative.")]
        public void MakeFromTwoAnglesAndSide_NullOrNegativeAngle_ExceptionThrown()
        {
            double a = 5;
            double angle1 = -45;
            double angle2 = 90;
            TriangleLib.Triangle.MakeFromTwoAnglesAndSide(angle1, angle2, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The sum of angles of a triangle must be less than 180 degrees.")]
        public void MakeFromTwoAnglesAndSide_SumOfAnglesIsMoreThan180_ExceptionThrown()
        {
            double a = 5;
            double angle1 = 99;
            double angle2 = 90;
            TriangleLib.Triangle.MakeFromTwoAnglesAndSide(angle1, angle2, a);
        }

        [TestMethod]
        public void GetleArea_TwoAnglesAndSide_AreaCalculatedCorrectly()
        {
            double a = 4;
            double angle1 = 60;
            double angle2 = 60;
            Assert.AreEqual(4*Math.Sqrt(3), TriangleLib.Triangle.MakeFromTwoAnglesAndSide(angle1, angle2, a).GetArea());
        }


    }
}
