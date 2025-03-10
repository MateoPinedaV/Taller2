class Kite : GeometricFigure
{
    public double Diagonal1 { get; set; }
    public double Diagonal2 { get; set; }
    public double SideA { get; set; }
    public double SideB { get; set; }

    public Kite(string name, double diagonal1, double diagonal2, double sideA, double sideB) : base(name)
    {
        Diagonal1 = diagonal1;
        Diagonal2 = diagonal2;
        SideA = sideA;
        SideB = sideB;
    }

    public override double GetArea()
    {
        return (Diagonal1 * Diagonal2) / 2; // Corregida fórmula del área
    }

    public override double GetPerimeter()
    {
        return 2 * (SideA + SideB);
    }
}