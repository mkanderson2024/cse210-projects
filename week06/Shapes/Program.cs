using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Green", 2);
        Rectangle rectangle = new Rectangle("Blue", 1, 4);
        Circle circle = new Circle("Red", 6);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"\nColor of the shape is: {color}");
            Console.WriteLine($"Area of the shape is: {area}");
        }
    }
}

//Alternatively Written Code: using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Notice that the list is a list of "Shape" objects. That means
//         // you can put any Shape objects in there, and also, any object where
//         // the class inherits from Shape
//         List<Shape> shapes = new List<Shape>();

//         Square s1 = new Square("Red", 3);
//         shapes.Add(s1);

//         Rectangle s2 = new Rectangle("Blue", 4, 5);
//         shapes.Add(s2);

//         Circle s3 = new Circle("Green", 6);
//         shapes.Add(s3);

//         foreach (Shape s in shapes)
//         {
//             // Notice that all shapes have a GetColor method from the base class
//             string color = s.GetColor();

//             // Notice that all shapes have a GetArea method, but the behavior is
//             // different for each type of shape
//             double area = s.GetArea();

//             Console.WriteLine($"The {color} shape has an area of {area}.");
//         }
//     }
// }