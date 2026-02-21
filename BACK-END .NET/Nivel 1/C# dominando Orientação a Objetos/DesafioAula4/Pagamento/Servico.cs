namespace DesafioAula4.Pagamento
{
    internal class Servico : IPagavel
    {
        public string Nome { get; set; }
        public decimal TaxaHora { get; set; }
        public int Horas { get; set; }

        public Servico(string nome, decimal taxaHora, int horas)
        {
            Nome = nome;
            TaxaHora = taxaHora;
            Horas = horas;
        }

        public decimal CalcularPagamento()
        {
            return TaxaHora * Horas;
        }
    }
}
