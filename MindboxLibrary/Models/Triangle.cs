using MindboxLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxLibrary.Models
{
    public class Triangle : IFigure
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentOutOfRangeException("Длина стороны должна быть положительным числом");

            if (!Utils.IsValidTriangle(side1, side2, side3))
                throw new ArgumentException("Недопустимые значения длин сторон для треугольника");

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double GetArea()
        {
            double semiperimeter = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - _side1) * (semiperimeter - _side2) * (semiperimeter - _side3));
        }

        public bool IsRightTriangle()
        {
            return Math.Pow(_side3, 2) == (Math.Pow(_side1, 2) + Math.Pow(_side2, 2));
        }
    }
}
