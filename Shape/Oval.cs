using System;
using CSharp_Abstracting_Shape;

namespace CSharp_Abstracting_Shape.Shape
{
    public class Oval : GeometricShape
    {
        private double height, width;
        private const double PI = 3.14d;
        public Oval(double height, double width) 
        { 
            this.width = width;
            this.height = height;
        }
        public override double area()
        {
            return width * height * PI;
        }
        public override double perimeter() 
        { 
            return (2 * PI) * Math.Sqrt((height * height + width * width)/2);
        }
    }
}
