namespace OOPShapeExample.Shapes.Polygon.Quadrilateral
{
    public sealed class Parallelogram : Quadrilateral
    {
        public override string TypeName => nameof(Parallelogram);

        private readonly double _sideLength;
        private readonly double _baseLength;
        private readonly double _height;

        public Parallelogram(double sideLength, double baseLength, double height)
            : base(sideLength, baseLength, sideLength, baseLength)
        {
            _sideLength = sideLength;
            _baseLength = baseLength;
            _height = height;
        }
        public override double Area()
        {
            return _baseLength * _height;
        }
    }
}
