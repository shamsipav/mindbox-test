using MindboxLibrary.Interfaces;

namespace MindboxLibrary.Models
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Радиус должен быть положительным числом");

            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
