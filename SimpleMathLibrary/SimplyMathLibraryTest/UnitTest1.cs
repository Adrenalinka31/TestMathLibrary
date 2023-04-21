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
            //Наш экземпляр фигуры
            IShape shape = new Circle(10);

            //Вызываем метод для получения площади
            double area = IShapeResponse.Calculate(shape);

            //Проверка
            Assert.AreEqual(314.1592653589793, area, 0.0001);

        }
        [Test]
        public void CalculateTriangle()
        {
            //Наш экземпляр фигуры
            IShape shape = new Triangle(3,4,5);

            //Вызываем метод для получения площади
            double area = IShapeResponse.Calculate(shape);

            //Проверка
            Assert.AreEqual(6, area);

        }
        [Test]
        public void IsRightTriangle()
        {
            //Наш экземпляр фигуры
            IShape shape = new Triangle(3, 3, 3);

            //Вызываем метод для получения площади
            bool area = IShapeResponse.IsRight(shape);

            //Проверка
            Assert.AreEqual(false, area);

        }


    }
}