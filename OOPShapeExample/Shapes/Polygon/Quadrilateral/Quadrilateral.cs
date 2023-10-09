namespace OOPShapeExample.Shapes.Polygon.Quadrilateral
{
    public abstract class Quadrilateral : Polygon
    {
        private protected Quadrilateral(double sideA, double sideB, double sideC, double sideD) 
            : base(sideA, sideB, sideC, sideD) { }

        public abstract override double Area();
    }
}
