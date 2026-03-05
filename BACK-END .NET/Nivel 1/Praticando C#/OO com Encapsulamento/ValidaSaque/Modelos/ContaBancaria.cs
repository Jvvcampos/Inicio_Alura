using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaSaque.Modelos
{
    internal class ContaBancaria
    {
        public string Titular { get; }
        private double _saldo;
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public ContaBancaria(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            bool respostaSaque = SegurancaConta.ValidarSaque(valor);
            if (respostaSaque)
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine($"Saldo atual: {Saldo}");
                return;
            }
            Console.WriteLine("Saque negado pela política de segurança!");
        }
    }
}
