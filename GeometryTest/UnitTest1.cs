using Geometry;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalcPerimeterTriangleEqual()
        {
            double square = 12;
            var triangle = new Triangle();
            triangle.CalcPerimeter(3, 4, 5);

            Assert.AreEqual(triangle.Perimeter, square);
        }

        [Test]
        public void CalcSquareTriangleEqual()
        {
            double square = 6;
            var triangle = new Triangle();
            triangle.CalcSquare(3, 4, 5);

            Assert.AreEqual(triangle.Square, square);
        }

        [Test]
        public void CalcSquare—ircleEqual()
        {
            double square = Math.PI * (2 * 2);
            var circle = new —ircle();
            circle.CalcSquare(2);

            Assert.AreEqual(circle.Square, square);
        }

        [Test]
        public void IsRightTriangleTrue()
        {
            bool isRightTriangle = true;
            var triangle = new Triangle();

            Assert.AreEqual(triangle.IsRightTriangle(3, 4, 5), isRightTriangle);
        }
    }
}