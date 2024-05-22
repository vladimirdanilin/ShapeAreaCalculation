using ShapeAreaCalculation.Shapes;

namespace ShapeAreaCalculation
{
    public class ShapeFactory
    {
        //Создает фигуру указанного типа с заданныит параметрами
        public static IShape AddShape(string typeOfShape, params double[] shapeParameters)
        {
            return typeOfShape.ToLower() switch
            {
                "circle" when shapeParameters.Length == 1 => new Circle(shapeParameters[0]),
                "triangle" when shapeParameters.Length == 3 => new Triangle(shapeParameters[0], shapeParameters[1], shapeParameters[2]),
                _ => throw new ArgumentException("Invalid shape type or parameters")
            };
        }
    }
}
