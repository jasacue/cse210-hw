public class Circle : Shape
{
    private double _radius;


    public Circle(double radius, string color)
        :base (color)
    {
        _radius = radius;
        _color = color;
    }

    public override double GetArea()
    {
        return 3.14*(_radius*_radius);
    }
}