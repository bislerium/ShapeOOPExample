namespace OOPShapeExample.Shapes.Polygon.Triangle
{
    public class Triangle : Polygon
    {
        public override string TypeName => nameof(Triangle);

        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC) 
            : base(sideA, sideB, sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double Area()
        {
            double semiperimeter = (_sideA + _sideB + _sideC) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - _sideA) * (semiperimeter - _sideB) * (semiperimeter - _sideC));
            return area;
        }
    }
}
