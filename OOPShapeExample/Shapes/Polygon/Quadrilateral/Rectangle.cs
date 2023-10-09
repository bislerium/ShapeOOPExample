namespace OOPShapeExample.Shapes.Polygon.Quadrilateral
{
    public sealed class Rectangle : Quadrilateral
    {
        public override string TypeName => nameof(Rectangle);

        private readonly double _sideLength;
        private readonly double _baseLength;

        public Rectangle(double sideLength, double baselength)
            : base(sideLength, baselength, sideLength, baselength)
        {
            _sideLength = sideLength;
            _baseLength = baselength;
        }

        public override double Area()
        {
            return _sideLength * _baseLength;
        }
    }
}
