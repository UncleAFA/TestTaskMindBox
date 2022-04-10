using System;

namespace ClassLibraryMindBox.Figures
{
    public class Circle : Figure
    {

        public override double Square => FindingSquare();

        private readonly double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override bool CheckingCorrectness()
        {
            return Radius < 0;
        }

        public override double FindingSquare()
        {
            if (CheckingCorrectness()) return -1;

            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
