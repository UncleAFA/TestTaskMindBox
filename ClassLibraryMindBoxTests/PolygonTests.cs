using NUnit.Framework;
using ClassLibraryMindBox.Figures;
using ClassLibraryMindBox;

namespace ClassLibraryMindBoxTests
{
    public class PolygonTests
    {
        [Test]
        public void CheckingСorrectnessСalculationSquare()
        {
            Polygon polygon= new Polygon(
                new Coordinate(20, 10),
                new Coordinate(20, 30),
                new Coordinate(20, 60),
                new Coordinate(50, 50),
                new Coordinate(110, 60) );
            Assert.AreEqual(1800, polygon.Square);
        }
    }
}