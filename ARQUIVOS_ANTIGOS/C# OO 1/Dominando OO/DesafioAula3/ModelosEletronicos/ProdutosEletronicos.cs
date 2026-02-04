namespace DesafioAula3.ModelosEletronicos;
internal class ProdutosEletronicos
{
    public string Modelo { get; set; }
    public double Preco { get; set; }

    public virtual string ExibirInformacoes()
    {
        return $"Modelo: {Modelo}, Preço: {Preco:C}";
    }
}

