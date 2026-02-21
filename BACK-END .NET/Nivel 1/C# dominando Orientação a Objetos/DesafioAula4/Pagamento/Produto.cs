namespace DesafioAula4.Pagamento
{
    internal class Produto : IPagavel
    {
        public string Nome { get; set; }
        public decimal PrecoUnit { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, decimal precounit, int quantidade)
        {
            this.Nome = nome;
            this.PrecoUnit = precounit;
            this.Quantidade = quantidade;
        }
        public decimal CalcularPagamento()
        {
            return PrecoUnit * Quantidade;
        }
    }
}
