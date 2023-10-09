namespace OOPShapeExample.Shapes.Polygon.Quadrilateral
{
    public sealed class Square : Quadrilateral
    {
        public override string TypeName => nameof(Square);

        private readonly double _sideLength;

        public Square(double sideLength) 
            : base(sideLength, sideLength, sideLength, sideLength)
        {
            _sideLength = sideLength;
        }

        public override double Area()
        {
            return Math.Pow(_sideLength, 2);
        }
        
        // Operator overloading for + operator than adds two square of same size, perfectly aligned to form a rectangle.
        public static Rectangle operator +(Square left, Square right)
        {
            ArgumentNullException.ThrowIfNull(left);
            ArgumentNullException.ThrowIfNull(right);

            if (left._sideLength != right._sideLength)
            {
                throw new ArgumentException("Same sized square required!");
            }

            return new Rectangle(left._sideLength + right._sideLength, left._sideLength);
        }

    }
}
