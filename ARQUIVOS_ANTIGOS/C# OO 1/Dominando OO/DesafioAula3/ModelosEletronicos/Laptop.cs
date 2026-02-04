namespace DesafioAula3.ModelosEletronicos;
internal class Laptop : ProdutosEletronicos
{
    public string Processador { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, Processador: {Processador}";
    }
}
