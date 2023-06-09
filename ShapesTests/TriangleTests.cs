using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void AreaTest()
        {
            Shape shape = new Triangle(3, 4, 5);
            Assert.AreEqual(shape.Area(), 6);

            shape = new Triangle(13, 14, 15);
            Assert.AreEqual(shape.Area(), 84);

            shape = new Triangle(10, 15, 20);
            Assert.AreEqual(Math.Round(shape.Area(), 4), 72.6184);
        }

        [TestMethod()]
        public void TriangleTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Shape shape = new Triangle(1, 2, 3);
            });

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Shape shape = new Triangle(1, 3, 1);
            });
        }

        [TestMethod()]
        public void RightTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle);

            triangle = new Triangle(4, 5, 3);
            Assert.IsTrue(triangle.IsRightTriangle);

            triangle = new Triangle(7, 6, 4);
            Assert.IsTrue(!triangle.IsRightTriangle);
        }
    }
}