using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("green",2.2);
        square.GetColor();
        Console.WriteLine(square.GetArea());
        Rectangle rectangle = new Rectangle("orange",2.2,5);
        rectangle.GetColor();
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("black",2.2);
        circle.GetColor();
        Console.WriteLine(circle.GetArea());

        List<Shape> list = new List<Shape> {square, rectangle, circle};
        Console.WriteLine("Polymorphism with a list!");
        foreach (Shape shape in list)
        {
            Console.WriteLine(shape);
            shape.GetColor();
            Console.WriteLine(shape.GetArea());
            
        }

        Shape s1 = new Circle("blue", 6);
        Shape s2 = new Rectangle("red",100,2);
        Shape s3 = new Square("white", 1);


        


        
    }
}