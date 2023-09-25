using MindboxLibrary.Models;
using System;
using Xunit;

namespace Tests
{
    public class FiguresTest
    {
        private readonly AreaCalculator _calculator;

        public FiguresTest()
        {
            _calculator = new AreaCalculator();
        }

        [Fact]
        public void CircleReturnsCorrectArea()
        {
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            double actualArea = _calculator.CalculateArea(new Circle(radius));

            Assert.Equal(expectedArea, actualArea, precision: 2);
        }

        [Fact]
        public void CircleIsInvalidRadius()
        {
            double radius = -5;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }

        [Fact]
        public void TriangleReturnsCorrectArea()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;

            double actualArea = _calculator.CalculateArea(new Triangle(side1, side2, side3));

            Assert.Equal(expectedArea, actualArea, precision: 2);
        }

        [Fact]
        public void TriangleIsInvalidSides()
        {
            double side1 = 3;
            double side2 = -4;
            double side3 = 5;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(side1, side2, side3));
        }

        [Fact]
        public void TriangleIsInvalid()
        {
            double side1 = 1;
            double side2 = 2;
            double side3 = 10;

            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }

        [Fact]
        public void TriangleIsRight()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.True(isRightTriangle);
        }

        [Fact]
        public void TriangleIsNotRight()
        {
            double side1 = 2;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.False(isRightTriangle);
        }
    }
}