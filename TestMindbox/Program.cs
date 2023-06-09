using Shapes;

namespace TestMindbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Triangle(3, 4, 5));
            shapes.Add(new Triangle(5, 4, 3));
            shapes.Add(new Triangle(2, 2, 3));
            shapes.Add(new Circle(1));
            shapes.Add(new Circle(2));

            foreach (Shape shape in shapes)
            {
                Console.Write(shape.Area());

                if(shape is Triangle)
                {
                    Console.Write(", " + ((Triangle)shape).IsRightTriangle);
                }

                Console.WriteLine();
            }
        }
    }
}