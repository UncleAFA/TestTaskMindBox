using NUnit.Framework;
using ClassLibraryMindBox.Figures;

namespace ClassLibraryMindBoxTests
{
    public class TriangleTests
    {
        [Test]
        public void CheckingСorrectnessСalculationSquare()
        {
            Triangle triangle = new Triangle(8, 10, 6);
            Assert.AreEqual(24.0d, triangle.Square);
        }

        [Test]
        public void CheckingCorrectnessInput()
        {
            Triangle triangle = new Triangle(-3, -4, -5);
            Assert.AreEqual(-1, triangle.Square);
        }

        [Test]
        public void CheckingHasRightAngle()
        {
            Triangle triangle = new Triangle(8, 10, 6);
            Assert.IsTrue(triangle.IsRectangular);
        }

        [Test]
        public void CheckingHasNotRightAngle()
        {
            Triangle triangle = new Triangle(5, 4, 2);
            Assert.IsFalse(triangle.IsRectangular);
        }
    }
}