using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary
{
    public class Triangle : IShape
    {
        private double a, b, c;
         public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double CalculateArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public bool IsRightTriangle()
        {
            // Находим наибольшую сторону.
            double max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            // Проверяем теорему Пифагора.
            if (max * max == a * a + b * b + c * c - max * max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
