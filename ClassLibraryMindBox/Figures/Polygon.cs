using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryMindBox.Figures
{
    public class Polygon : Figure
    {
        public override double Square => FindingSquare();
        public List<Coordinate> ListPoints;

        public Polygon(params Coordinate[] Points)
        {
            ListPoints = Points.ToList();
        }

        public override bool CheckingCorrectness()
        {
            return false;
        }

        public override double FindingSquare()
        {
            double Amount = 0;
            for (int i = 0; i < ListPoints.Count; i++)
            {
                var j = (i + 1) % ListPoints.Count;
                var PointOne = ListPoints[i];
                var PointTwo = ListPoints[j];

                Amount += PointOne.X * PointTwo.Y - PointOne.Y * PointTwo.X;
            }
            return Math.Abs(Amount) * 0.5;
        }
    }
}
