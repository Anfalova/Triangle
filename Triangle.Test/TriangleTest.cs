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
            double a = 0, b = 5, c = 5;
            TriangleLib.Triangle.MakeFromThreeSides(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Triangle Rule is not satisfied.")]
        public void MakeFromThreeSides_NoTriangle_ExceptionThrown()
        {
            double a = 1, b = 1, c = 100000;
            TriangleLib.Triangle.MakeFromThreeSides(a, b, c);
        }

        [TestMethod]
        public void CalcTriangleArea_ThreeSides_AreaCalculatedCorrectly()
        {
            double a = 3, b = 4, c = 5;
            Assert.AreEqual(6, TriangleLib.Triangle.MakeFromThreeSides(a, b, c).CalcTriangleArea());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Angle of triangle can't be null or negative.")]
        public void MakeFromTwoSidesAndAngle_NullOrNegativeAngle_ExceptionThrown()
        {
            double a = 5, b = 5, angle = -1;
            TriangleLib.Triangle.MakeFromTwoSidesAndAngle(a, b, angle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Angle of triangle can't be  more than 180 degrees.")]
        public void MakeFromTwoSidesAndAngle_MoreThan180Angle_ExceptionThrown()
        {
            double a = 5, b = 5, angle = 278;
            TriangleLib.Triangle.MakeFromTwoSidesAndAngle(a, b, angle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Side of triangle can't be null or negative.")]
        public void MakeFromTwoSidesAndAngle_NullOrNegativeSide_ExceptionThrown()
        {
            double a = 5, b = -5, angle = 90;
            TriangleLib.Triangle.MakeFromTwoSidesAndAngle(a, b, angle);
        }

        [TestMethod]
        public void CalcTriangleArea_TwoSidesAndAngle_AreaCalculatedCorrectly()
        {
            double a = 3, b = 4, angle = 90;
            Assert.AreEqual(6, TriangleLib.Triangle.MakeFromTwoSidesAndAngle(a, b, angle).CalcTriangleArea());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Side of triangle can't be null or negative.")]
        public void MakeFromTwoAnglesAndSide_NullOrNegativeSide_ExceptionThrown()
        {
            double a = -5, angle1 = 45, angle2 = 90;
            TriangleLib.Triangle.MakeFromTwoAnglesAndSide(angle1, angle2, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Angle of triangle can't be null or negative.")]
        public void MakeFromTwoAnglesAndSide_NullOrNegativeAngle_ExceptionThrown()
        {
            double a = 5, angle1 = -45, angle2 = 90;
            TriangleLib.Triangle.MakeFromTwoAnglesAndSide(angle1, angle2, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The sum of angles of a triangle must be less than 180 degrees.")]
        public void MakeFromTwoAnglesAndSide_SumOfAnglesIsMoreThan180_ExceptionThrown()
        {
            double a = 5, angle1 = 99, angle2 = 90;
            TriangleLib.Triangle.MakeFromTwoAnglesAndSide(angle1, angle2, a);
        }

        [TestMethod]
        public void CalcTriangleArea_TwoAnglesAndSide_AreaCalculatedCorrectly()
        {
            double a = 4, angle1 = 60, angle2 = 60;
            Assert.AreEqual(4*Math.Sqrt(3), TriangleLib.Triangle.MakeFromTwoAnglesAndSide(angle1, angle2, a).CalcTriangleArea());
        }


    }
}
