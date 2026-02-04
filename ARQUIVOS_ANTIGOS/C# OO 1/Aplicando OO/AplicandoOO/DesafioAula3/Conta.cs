using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula3
{
    class Conta
    {
        public Conta(Titular titular, int agencia, int numeroDaConta, double saldo, double limite)
        {
            this.Titular = titular;
            this.Agencia = agencia;
            this.NumeroDaConta = numeroDaConta;
            this.Saldo = saldo;
            this.Limite = limite;
        }

        public Titular Titular { get; set; }
        public int Agencia { get; set; }
        public int NumeroDaConta { get; set; }
        public double Saldo { get; }
        public double Limite { get; set; }

        public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
    }
}
