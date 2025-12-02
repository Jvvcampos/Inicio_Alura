namespace DesafioAula3.ModelosConta;
internal class ContaBancaria
{
    public string NomeTitular { get; set; }
    public double Saldo { get; set; }

    public virtual double Sacar(double valor)
    {
        return Saldo-=valor;
    }

    public virtual double Depositar(double valor)
    {
        return Saldo += valor;
    }
}
