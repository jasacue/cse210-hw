using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> s = new List<Shape>();
        Square t = new Square(2, "Red");
        Rectangle r = new Rectangle(5, 4, "Green");
        Circle c = new Circle(4, "Blue");
        s.Add(t);
        s.Add(r);
        s.Add(c);
        foreach (var z in s)
        {
            Console.WriteLine($"Area: {z.GetArea()}, Color: {z.GetColor()}");
        }
    }
}