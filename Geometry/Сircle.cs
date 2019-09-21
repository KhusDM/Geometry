using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Сircle : Figure
    {
        public void CalcSquare(double radius)
        {
            if (!СheckRadius(radius))
            {
                Console.WriteLine("Некорректный радиус");

                return;
            }

            Square = Math.PI * (radius * radius);
        }

        private bool СheckRadius(double radius)
        {
            if (radius > 0)
                return true;

            return false;
        }
    }
}
