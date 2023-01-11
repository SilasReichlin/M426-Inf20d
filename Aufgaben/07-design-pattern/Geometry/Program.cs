using System;
using Geometry.ThirdParty;

namespace Geometry
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IRectangular rectangle = new Rectangle(3, 4);
            Console.WriteLine(rectangle);
            Console.WriteLine("Area:\t\t" + Calculator.GetArea(rectangle));
            Console.WriteLine("Perimeter:\t" + Calculator.GetPerimeter(rectangle));
            Console.WriteLine("Diagonal:\t" + Calculator.GetDiagonal(rectangle));

            IQuadratic square = new Square(3);
            IRectangular rectSquare = new RectangleAdapter(square);
            Console.WriteLine(square);
            Console.WriteLine("Height width ratio:\t" + Calculator.GetWidthHeightRatio(rectSquare));
            Console.WriteLine("Area:\t\t" + Calculator.GetArea(rectSquare));
            Console.WriteLine("Perimeter:\t" + Calculator.GetPerimeter(rectSquare));
            Console.WriteLine("Diagonal:\t" + Calculator.GetDiagonal(rectSquare));
        }
    }
}
