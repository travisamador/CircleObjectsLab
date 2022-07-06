using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjectsLab
{
    internal class Circle
    {
        private double Radius { get; set; }
        public static int circleCount;
        public Circle(double _radius)
        {
            Radius = _radius;
            circleCount++;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }

        private string FormatNumber(double x)
        {
            
            return Math.Round(x, 2).ToString();
        }
    }
}
