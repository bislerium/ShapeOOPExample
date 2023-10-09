namespace OOPShapeExample.Shapes.Polygon
{
    public abstract class Polygon : I2DShape
    {

        //Property without setter
        public abstract string TypeName { get; }

        // Field (mostly used as private)
        private readonly double[] _sides;

        //Parameterized Constructor that takes variable number of arguments
        private protected Polygon(params double[] sides) => _sides = sides;

        // F=> can be use only for one statement, while {} is used for one or multiple statement(s).
        public double Perimeter() => _sides.Sum();

        // Abstract method
        public abstract double Area();
    }
}
