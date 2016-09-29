using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleLib;
namespace Triangle.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThreeSides_ZeroSide_ExceptionThrown()
        {
            double a = 0, b = 5, c = 5;
            TriangleClass.ThreeSides(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThreeSides_NoTriangle_ExceptionThrown()
        {
            double a = 1, b = 1, c = 100000;
            TriangleClass.ThreeSides(a, b, c);
        }

        [TestMethod]
        public void TriangleSquareSolver_ThreeSides_ExistingTriangle()
        {
            double a = 3, b = 4, c = 5;
            Assert.AreEqual(6, TriangleClass.ThreeSides(a, b, c).TriangleSquare());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TwoSidesAndAngle_NegativeAngle_ExceptionThrown()
        {
            double a = 5, b = 5, angle = -1;
            TriangleClass.TwoSidesAndAngle(a, b, angle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TwoSidesAndAngle_MoreThan180Angle_ExceptionThrown()
        {
            double a = 5, b = 5, angle = 278;
            TriangleClass.TwoSidesAndAngle(a, b, angle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TwoSidesAndAngle_NegativeSide_ExceptionThrown()
        {
            double a = 5, b = -5, angle = 90;
            TriangleClass.TwoSidesAndAngle(a, b, angle);
        }

        [TestMethod]
        public void TriangleSquareSolver_TwoSidesAndAngle_ExistingTriangle()
        {
            double a = 3, b = 4, angle = 90;
            Assert.AreEqual(6, TriangleClass.TwoSidesAndAngle(a, b, angle).TriangleSquare());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TwoAnglesAndSide_NegativeSide_ExceptionThrown()
        {
            double a = -5, angle1 = 45, angle2 = 90;
            TriangleClass.TwoAnglesAndSide(angle1, angle2, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TwoAnglesAndSide_NegativeAngle_ExceptionThrown()
        {
            double a = 5, angle1 = -45, angle2 = 90;
            TriangleClass.TwoAnglesAndSide(angle1, angle2, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TwoAnglesAndSide_SumOfAnglesIsMoreThan180_ExceptionThrown()
        {
            double a = 5, angle1 = 99, angle2 = 90;
            TriangleClass.TwoAnglesAndSide(angle1, angle2, a);
        }

        [TestMethod]
        public void TriangleSquareSolver_TwoAnglesAndSide_ExistingTriangle()
        {
            double a = 4, angle1 = 60, angle2 = 60;
            Assert.AreEqual(4*Math.Sqrt(3), TriangleClass.TwoAnglesAndSide(angle1, angle2, a).TriangleSquare(), 1e-10);
        }


    }
}
