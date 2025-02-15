using System;

public class Circle : Shape
{
    //Member variables
    double _radius = 0;

    //Constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    //Method
    public override double GetArea()
    {
        double r = _radius * _radius;
        return Math.PI * r;
    }
}

//Alternatively Written Code

// public class Circle : Shape
// {
//     private double _radius;

//     public Circle(string color, double radius) : base (color)
//     {
//         _radius = radius;
//     }

//     // Notice the use of the override keyword here
//     public override double GetArea()
//     {
//         return _radius * _radius * Math.PI;
//     }
// }