using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Abstracting_Shape.Shape
{
    public class Circle : GeometricShape
    {
        private double radius;
        public Circle(double rad)
        {
            radius = rad;
        }

        public override double area()
        {
            return 3.14*radius*radius;
        }

        public override double perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
