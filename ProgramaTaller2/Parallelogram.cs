class Parallelogram : GeometricFigure
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double Side { get; set; }

    public Parallelogram(string name, double baseLength, double height, double side) : base(name)
    {
        Base = baseLength;
        Height = height;
        Side = side;
    }

    public override double GetArea()
    {
        return Base * Height; // Corregida fórmula del área
    }

    public override double GetPerimeter()
    {
        return 2 * (Base + Side);
    }
}