namespace DesafioAula3.ModelosFormas;
internal class Quadrado : FormasGeometricas
{
    public double lado { get; set; }

    public override double CalcularArea()
    {
        return lado * lado;
    }

    public override double CalcularPerimetro()
    {
        return 4 * lado;
    }
}

