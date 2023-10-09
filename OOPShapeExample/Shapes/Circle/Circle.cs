namespace OOPShapeExample.Shapes.Circle
{
    public class Circle : I2DShape
    {
        public string TypeName => nameof(Circle);

        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
