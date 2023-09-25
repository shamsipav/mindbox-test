using MindboxLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxLibrary.Models
{
    public class AreaCalculator
    {
        public double CalculateArea(IFigure figure)
        {
            return figure.GetArea();
        }
    }
}
