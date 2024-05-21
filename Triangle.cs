using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation
{
    public class Triangle : Shape
    {
        //Стороны треугольника
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        //Метод, вычисляющий площадь треугольника по трем сторонам
        public override double CalculateArea()
        {
            //Расчет полупериметра треугольника
            double p = (SideA + SideB + SideC) / 2;

            //Расчет площади треугольника по формуле Герона
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        //Метод, проверяющий треугольник на прямоугольность
        public bool IsRightTriangle()
        {
            //Список, содержащий стороны треугольника
            List<double> sidesOfTriangle = new List<double> { SideA, SideB, SideC };
            sidesOfTriangle.Sort();

            //Проверка треугольника на прямоугольность по теореме Пифагора
            return Math.Pow(sidesOfTriangle[2], 2) == Math.Pow(sidesOfTriangle[0], 2) + Math.Pow(sidesOfTriangle[1], 2);
        }
    }
}
