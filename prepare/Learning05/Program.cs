using System;

class Program{
    static void Main(string[] args){
        Console.WriteLine("Welcome to this class for practicing Polymorphism");

        List<Shape> shapesList = new List<Shape>();

        // Creating the display individually
        Square square= new Square("Blue",2.5);
        square.DisplayColorArea();

        Rectangle rectangle = new Rectangle("Red", 8.0,4.0);
        rectangle.DisplayColorArea();

        Circle circle = new Circle("Yellow",3);
        circle.DisplayColorArea();

        // Creating the display with a list
        shapesList.Add(square);
        shapesList.Add(rectangle);
        shapesList.Add(circle);

        System.Console.WriteLine("-------------------------");
        foreach(Shape shape in shapesList){
            shape.DisplayColorArea();
        }

    }
}
