using OOPShapeExample.Shapes;

namespace OOPShapeExample.Printer
{
    // Printer that prints the info about shape. Includes Type, Area, Perimeter etc.
    public static class Printer
    {
        public static void Print(I2DShape shape)
        {
            Console.WriteLine($" => The given {shape.TypeName} shape has an area of {shape.Area()} square units and perimeter of {shape.Perimeter()} units.");
        }

        public static void Print(params I2DShape[] shapes)
        {
            DrawLine();
            foreach (var shape in shapes)
            {
                Console.WriteLine(Environment.NewLine);
                Print(shape);
                Console.WriteLine(Environment.NewLine);
                DrawLine();
            }
        }

        private static void DrawLine() => Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
    }
}
