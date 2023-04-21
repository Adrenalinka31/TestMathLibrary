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
            //��� ��������� ������
            IShape shape = new Circle(10);

            //�������� ����� ��� ��������� �������
            double area = IShapeResponse.Calculate(shape);

            //��������
            Assert.AreEqual(314.1592653589793, area, 0.0001);

        }
        [Test]
        public void CalculateTriangle()
        {
            //��� ��������� ������
            IShape shape = new Triangle(3,4,5);

            //�������� ����� ��� ��������� �������
            double area = IShapeResponse.Calculate(shape);

            //��������
            Assert.AreEqual(6, area);

        }
        [Test]
        public void IsRightTriangle()
        {
            //��� ��������� ������
            IShape shape = new Triangle(3, 3, 3);

            //�������� ����� ��� ��������� �������
            bool area = IShapeResponse.IsRight(shape);

            //��������
            Assert.AreEqual(false, area);

        }


    }
}