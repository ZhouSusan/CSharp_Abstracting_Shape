using System;

namespace CSharp_Abstracting_Shape.Shape
{
    public class Triangle : GeometricShape
    {
        private double _num1, _num2, _num3;

        public Triangle(double num1, double num2)
        {
            _num1 = num1;
            _num2 = num2;   
        }

        public Triangle(double num1, double num2, double num3)
        {
            _num1 = num1;
            _num2 = num2;
            _num3 = num3;
        }
        public override double area()
        {
            return 0.5*(_num1*_num2);
        }

        public override double perimeter()
        {
            return _num1 + _num2 + _num3;
        }
    }
}
