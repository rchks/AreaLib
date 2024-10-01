using AreaLib.Models.Triangle;

namespace AreaLibTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleAreaTest() 
        {
            var triangles = new Triangle[]
            {
                new Triangle(1.0, 2.0, 3.0),
                new Triangle(4, 6, 9),
                new Triangle(5, 5, 8)
            };

            foreach (var triangle in triangles) 
            {
                var p = (triangle.EdgeA + triangle.EdgeB + triangle.EdgeC) / 2;
                var expectedArea = Math.Sqrt(p * (p - triangle.EdgeA) * (p - triangle.EdgeB) * (p - triangle.EdgeC));
                var area = triangle.Area();
                Assert.AreEqual(expectedArea, area);
            }
        }

        [TestMethod]
        public void TriangleRightTest() 
        {
            var triangle = new Triangle(3.0, 4.0, 5.0);
            Assert.IsTrue(triangle.IsRightAngled());
        }

        [TestMethod]
        public void TriangleNotRightTest()
        {
            var triangle = new Triangle(1.0, 2.0, 3.0);
            Assert.IsFalse(triangle.IsRightAngled());
        }

        [TestMethod]
        public void NotTriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1.0, 3.0, 5.0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 0, 0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, -1, 3));
        }
    }
}
