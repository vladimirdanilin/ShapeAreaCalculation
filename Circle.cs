using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation
{
    public class Circle : Shape
    {
        //Радиус круга
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        //Метод, вычисляющий площадь круга по радиусу
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
