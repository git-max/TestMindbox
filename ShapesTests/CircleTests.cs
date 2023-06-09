using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void AreaTest()
        {
            Shape shape = new Circle(1);
            Assert.AreEqual(Math.Round(shape.Area(), 4), 3.1416);

            shape = new Circle(2);
            Assert.AreEqual(Math.Round(shape.Area(), 4), 12.5664);
        }

        [TestMethod()]
        public void CircleTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Shape shape = new Circle(0);
            });

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Shape shape = new Circle(-1);
            });
        }
    }
}