using System;
using SharpShapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleTest()
        {
            Circle circle = new Circle();
            double radius = 1;
            Assert.AreEqual(Circle.pi, circle.area(radius));
            Assert.AreEqual(Circle.pi * 2 * radius, circle.diameter(radius));
        }

        [TestMethod]
        public void SquareTest()
        {
            Square square = new SharpShapes.Square();
            Assert.AreEqual(9, square.area(3));
            Assert.AreEqual(12, square.perimeter(3));
        }

        [TestMethod]
        public void RhombusTest()
        {
            Rhombus rhombus = new SharpShapes.Rhombus();
            Assert.AreEqual(16, rhombus.area(4));
            Assert.AreEqual(20, rhombus.perimeter(5));
        }

        [TestMethod]
        public void CylinderTest()
        {
            Cylinder cylinder = new Cylinder();
            Assert.AreEqual(Cylinder.pi * 1 * 1 * 3, cylinder.volume(1, 3));
            Assert.AreEqual( (2 * Cylinder.pi * 1 * 3) + 2 * Cylinder.pi * 1 * 1, cylinder.area(1, 3) );
        }

        [TestMethod]
        public void CubeTest()
        {
            Cube cube = new SharpShapes.Cube();
            Assert.AreEqual(24, cube.area(2));
            Assert.AreEqual(8, cube.volume(2));
        }
    }
}
