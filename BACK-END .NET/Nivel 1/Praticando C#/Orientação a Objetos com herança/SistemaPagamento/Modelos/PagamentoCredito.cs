using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento.Modelos
{
    internal class PagamentoCredito : Pessoa, IPagamento
    {
        public decimal Valor { get; private set; }
        public PagamentoCredito(string nome, string email, decimal valor) : base(nome, email)
        {
            this.Valor = valor;
        }

        public void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento no crédito no valor de {Valor.ToString("C")} do cliente {Nome} foi enviado para o email {Email}");
        }
    }
}
