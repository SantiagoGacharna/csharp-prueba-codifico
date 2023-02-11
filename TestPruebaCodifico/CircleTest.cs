
using PruebaCodifico;

namespace TestPruebaCodifico
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalculateArea_RadiusIs8_Return2010619 ()
        {

            Circle circle = new Circle(8);

            double result = circle.CalculateArea();

            Assert.AreEqual(201.0619, result, 0.001);
        }

        [TestMethod]
        public void CalculateArea_RadiusIs0_Return0 ()
        {

            Circle circle = new Circle(0);

            double result = circle.CalculateArea();

            Assert.AreEqual(0, result);
        }
    }
}
