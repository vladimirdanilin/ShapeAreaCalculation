using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation
{
    public  interface IShape
    {
        //Метод, вычисляющий значение площади фигуры
        double CalculateArea(); 
    }
}
