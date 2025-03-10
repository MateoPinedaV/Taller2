class Rhombus : GeometricFigure
{
    public double Diagonal1 { get; set; }
    public double Diagonal2 { get; set; }
    public double Side { get; set; }

    public Rhombus(string name, double diagonal1, double diagonal2, double side) : base(name)
    {
        Diagonal1 = diagonal1;
        Diagonal2 = diagonal2;
        Side = side;
    }

    public override double GetArea()
    {
        return (Diagonal1 * Diagonal2) / 2; // Corregida fórmula del área
    }

    public override double GetPerimeter()
    {
        return 4 * Side;
    }
}