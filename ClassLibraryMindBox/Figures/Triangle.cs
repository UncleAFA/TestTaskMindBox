using System;

namespace ClassLibraryMindBox.Figures
{
    public class Triangle : Figure
    {
        public override double Square => FindingSquare();
        public bool IsRectangular => HasRightAngle();
        private readonly double A, B, C;

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override bool CheckingCorrectness()
        {
            return !(A + B > C && A + C > B && B + C > A);
        }

        private bool HasRightAngle()
        {
            return Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2) || Math.Pow(C, 2) + Math.Pow(A, 2) == Math.Pow(B, 2) || Math.Pow(B, 2) + Math.Pow(C, 2) == Math.Pow(A, 2);
        }

        public override double FindingSquare()
        {
            if (CheckingCorrectness()) return -1;

            double HalfPerimeter = (A + B + C) * 0.5;
            return Math.Sqrt(HalfPerimeter * (HalfPerimeter - A) * (HalfPerimeter - B) * (HalfPerimeter - C));
        }
    }
}
