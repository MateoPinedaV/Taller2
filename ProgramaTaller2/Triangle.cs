class Triangle : GeometricFigure
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }
    public double Height { get; set; }

    public Triangle(string name, double sideA, double sideB, double sideC, double height) : base(name)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        Height = height;
    }

    public override double GetArea()
    {
        return (SideB * Height) / 2;
    }

    public override double GetPerimeter()
    {
        return SideA + SideB + SideC;
    }
}