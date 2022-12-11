using System;

namespace CSharp_Abstracting_Shape.Shape
{
    internal class Square : GeometricShape
    {
        private double _side;
        public Square(double side)
        {
            _side = side;
        }
        public override double area()
        {
            return (_side * _side);
        }

        public override double perimeter()
        {
            return (4*_side);
        }
    }
}
