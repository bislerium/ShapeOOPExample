namespace OOPShapeExample.Shapes
{
    public interface I2DShape
    {
        string TypeName { get; }

        double Area();

        double Perimeter();
    }
}
