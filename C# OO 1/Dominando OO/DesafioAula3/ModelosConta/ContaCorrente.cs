namespace DesafioAula3.ModelosConta;
internal class ContaCorrente : ContaBancaria
{
    public double TaxaSaque { get; set; }
    public override double Sacar(double valor)
    {
        return base.Sacar(valor + TaxaSaque);
    }
}

