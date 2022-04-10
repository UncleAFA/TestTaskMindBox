using NUnit.Framework;
using ClassLibraryMindBox.Figures;

namespace ClassLibraryMindBoxTests
{
    public class CircleTests
    {
        [Test]
        public void Checking—orrectness—alculationSquare()
        {
            Circle circle = new Circle(15);
            Assert.AreEqual(706.85834705770344, circle.Square);
        }

        [Test]
        public void CheckingCorrectnessInput()
        {
            Circle circle = new Circle(-100);
            Assert.AreEqual(-1, circle.Square);
        }
    }
}