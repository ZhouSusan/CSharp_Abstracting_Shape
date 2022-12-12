using CSharp_Abstracting_Shape.Shape;
using CSharp_Abstracting_Shape;

namespace CSharp_Abstracting_Shape
{
        public class Program
    {
        public static void Main()
        {
            testCircle();
            testSquare();
            testTriangle();
            testOval();
        }
        private static void testCircle()
        {
            Console.WriteLine("Should not throw an exception.");
            Circle circle1 = new Circle(5);
            Console.WriteLine("Area of this circle should be: 78.5.");
            Console.WriteLine("We got: " + circle1.area());
            Console.WriteLine("The perimeter of our circle should be: 31.4");
            Console.WriteLine("We got: " + circle1.perimeter());
        }
        private static void testSquare() 
        {
            Console.WriteLine("Should not throw an exception.");
            Square square1 = new Square(5);
            Console.WriteLine("Area of this square should be: 25.0.");
            Console.WriteLine("We got: " + square1.area());
            Console.WriteLine("The perimeter of our square should be: 20.0");
            Console.WriteLine("We got: " + square1.perimeter());
        }
        private static void testTriangle()
        {
            Console.WriteLine("Should not throw an exception.");
            Triangle triangle1 = new Triangle(3, 4, 5);
            Console.WriteLine("Area of this triangle should be: 6.0.");
            Console.WriteLine("We got: " + triangle1.area());
            Console.WriteLine("The perimeter of our triangle should be: 12.0");
            Console.WriteLine("We got: " + triangle1.perimeter());
        }
        private static void testOval()
        {
            Console.WriteLine("Should not throw an exception.");
            Oval oval1 = new Oval(1, 2);
            Console.WriteLine("Area of this oval should be: 6.28.");
            Console.WriteLine("We got: " + oval1.area());
            Console.WriteLine("The perimeter of our oval should be: 9.93");
            Console.WriteLine("We got: " + oval1.perimeter());
        }
    }
}