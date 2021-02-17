using System;

namespace ShapesHomeworkV2 {
    class Program {
        static void Main(string[] args) {
            var quad1 = new Quad(1, 2, 3, 4);
            Console.WriteLine($"The perimeter of quad1 is {quad1.perimeter()}");

            var rect1 = new Rect(6, 4);
            Console.WriteLine($"The area of rect1 is {rect1.Area()}");

            var sqr1 = new Sqr(5);
            Console.WriteLine($"The perimeter of sqr1 is {sqr1.perimeter()}");
        }
    }
}
