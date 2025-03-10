class Square : GeometricFigure
{
    public double Side { get; set; }

    public Square(string name, double side) : base(name)
    {
        Side = side;
    }

    public override double GetArea()
    {
        return Math.Pow(Side, 2);
    }

    public override double GetPerimeter()
    {
        return 4 * Side;
    }
}