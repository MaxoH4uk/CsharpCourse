using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle("Прямоугольник", 5, 10);
            Console.WriteLine($"Название фигуры: { rectangle.GetName() }");
            Console.WriteLine("Площадь фигуры: {0:#.##}", rectangle.GetArea());
            Console.WriteLine("Периметр фигуры: {0:#.##}", rectangle.GetPerimeter());            
            Console.WriteLine();

            Circle circle = new Circle("Круг", 5);
            Console.WriteLine($"Название фигуры: { circle.GetName() }");
            Console.WriteLine("Площадь фигуры: {0:#.##}", circle.GetArea());
            Console.WriteLine("Периметр фигуры: {0:#.##}", circle.GetPerimeter());
            Console.WriteLine();

            Triangle triangle = new Triangle("Треугольник", 5, 6, 7, 8);
            Console.WriteLine($"Название фигуры: { triangle.GetName() }");
            Console.WriteLine("Площадь фигуры: {0:#.##}", triangle.GetArea());
            Console.WriteLine("Периметр фигуры: {0:#.##}", triangle.GetPerimeter());
            Console.WriteLine();

            Sector sector = new Sector("Сектор", 5, 6);
            Console.WriteLine($"Название фигуры: { sector.GetName() }");
            Console.WriteLine("Площадь фигуры: {0:#.##}", sector.GetArea());
            Console.WriteLine("Периметр фигуры: {0:#.##}", sector.GetPerimeter());
            Console.Read();
        }
    }
}
