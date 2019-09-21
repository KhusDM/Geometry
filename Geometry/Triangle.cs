using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Triangle : Figure
    {
        public void CalcPerimeter(double slide1, double slide2, double slide3)
        {
            if (!СheckSides(slide1, slide2, slide3))
            {
                Console.WriteLine("Некорректные длины сторон");

                return;
            }

            Perimeter = slide1 + slide2 + slide3;
        }

        public void CalcSquare(double slide1, double slide2, double slide3)
        {
            if (!СheckSides(slide1, slide2, slide3))
            {
                Console.WriteLine("Некорректные длины сторон");

                return;
            }

            if (Perimeter == 0)
                CalcPerimeter(slide1, slide2, slide3);

            double p = Perimeter / 2;
            Square = Math.Sqrt(p * (p - slide1) * (p - slide2) * (p - slide3));
        }

        public bool IsRightTriangle(double slide1, double slide2, double slide3)
        {

            if (!СheckSides(slide1, slide2, slide3))
            {
                Console.WriteLine("Некорректные длины сторон");

                return false;
            }

            bool check1 = slide1 * slide1 + slide2 * slide2 == slide3 * slide3;
            bool check2 = slide1 * slide1 + slide3 * slide3 == slide2 * slide2;
            bool check3 = slide2 * slide2 + slide3 * slide3 == slide1 * slide1;
            if (check1 || check2 || check3)
                return true;

            return false;
        }

        private bool СheckSides(double slide1, double slide2, double slide3)
        {
            if (slide1 <= 0 || slide2 <= 0 || slide3 <= 0)
                return false;

            return true;
        }
    }
}
