class Trapeze : GeometricFigure
{
    public double Base1 { get; set; }
    public double Base2 { get; set; }
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double Height { get; set; }

    public Trapeze(string name, double base1, double base2, double sideA, double sideB, double height) : base(name)
    {
        Base1 = base1;
        Base2 = base2;
        SideA = sideA;
        SideB = sideB;
        Height = height;
    }

    public override double GetArea()
    {
        return (Base1 + Base2) * Height / 2; // Corregida fórmula del área
    }

    public override double GetPerimeter()
    {
        return Base1 + Base2 + SideA + SideB; // Corregida fórmula del perímetro
    }
}
