class Rectangle : GeometricFigure
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(string name, double length, double width) : base(name)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }

    public override double GetPerimeter()
    {
        return 2 * (Length + Width);
    }
}