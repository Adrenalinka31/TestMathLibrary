using NUnit.Framework;
using SimpleMathLibrary;

namespace SimplyMathLibraryTest
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void CalculateCircle()
        {
            //Our instance of the figure
            IShape shape = new Circle(10);

            //Calling the method to get the area
            double area = IShapeResponse.Calculate(shape);

            //Check
            Assert.AreEqual(314.1592653589793, area, 0.0001);

        }
        [Test]
        public void CalculateTriangle()
        {
            //Our instance of the figure
            IShape shape = new Triangle(3,4,5);

            //Calling the method to get the area
            double area = IShapeResponse.Calculate(shape);

            //Check
            Assert.AreEqual(6, area);

        }
        [Test]
        public void IsRightTriangle()
        {
            //Our instance of the figure
            IShape shape = new Triangle(3, 3, 3);

            //Calling the method to get the area
            bool area = IShapeResponse.IsRight(shape);

            //Check
            Assert.AreEqual(false, area);

        }


    }
}