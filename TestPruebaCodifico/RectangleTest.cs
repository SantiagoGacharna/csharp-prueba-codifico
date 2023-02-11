
using PruebaCodifico;

namespace TestPruebaCodifico
{

    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void CalculateArea_WidthIs7HeightIs12_Return84 ()
        {

            Rectangle rectangle = new Rectangle(7, 12);

            double result = rectangle.CalculateArea();

            Assert.AreEqual(84, result);
        }

        [TestMethod]
        public void CalculateArea_WidthIs5HeightIs0_Return0 ()
        {
            Rectangle rectangle = new Rectangle(5, 0);

            double result = rectangle.CalculateArea();

            Assert.AreEqual(0, result);
        }
    }
}
