using OOPShapeExample.Printer;
using OOPShapeExample.Shapes;
using OOPShapeExample.Shapes.Polygon.Triangle;
using OOPShapeExample.Shapes.Polygon.Quadrilateral;
using OOPShapeExample.Shapes.Circle;

// {} can be used to group related code for better readability
{
    I2DShape _ = new Triangle(20, 15.25, 10); // Up-casting or Implicit type casting. Happens Automatic
    Triangle shapeA = (Triangle) _; //Down-casting or Explicit type casting. Should be manually done.
    I2DShape shapeB = new Rectangle(10, 10);
    I2DShape shapeC = new Circle(22.5);
    I2DShape shapeD = new Parallelogram(sideLength: 22.5, baseLength: 12.34, height: 10);
    I2DShape shapeE = new Square(60);

    // Exmple of Method overloading & Overwriting
    Printer.Print(shapeA);
    Printer.Print(shapeA, shapeB, shapeC, shapeD, shapeE);
}

{
    Square squareA = new(20);
    Square squareB = new(20);

    //Example of operator overloading [+ operator]
    Rectangle shapeE = squareA + squareB;

    Printer.Print(shapeE);
}
