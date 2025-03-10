abstract class GeometricFigure
{
    public string Name { get; set; }

    public GeometricFigure(string name)
    {
        Name = name;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name}\n=> Area...... {GetArea():F5}\nPerimeter: {GetPerimeter():F5}\n";
    }
}
