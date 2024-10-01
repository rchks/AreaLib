using AreaLib.Models.Circle;

namespace AreaLibTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                var radius = r.NextDouble() * 1000;
                var expectedArea = Math.Pow(radius, 2) * Math.PI;
                var area = new Circle(radius).Area();
                Assert.AreEqual(area, expectedArea);
            }
        }

        [TestMethod]
        public void ArgumentOutOfRangeTest() 
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-10));
        }
    }
}
