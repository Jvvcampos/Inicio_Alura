using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Conta
    {
        public string NumeroConta { get; }
        public double Saldo { get; private set; }

        public Conta(double saldo, string numeroConta)
        {
            if(saldo < 0)
            {
                Console.WriteLine("Você colocou um valor negativo, corrigido para 0.");
                saldo = 0;
            }
            this.Saldo = saldo;
            this.NumeroConta = numeroConta;
        }

        public void Depositar(double deposito)
        {
            if(deposito > 0)
            {
                Saldo += deposito;
                Console.WriteLine("Deposito realizado!");
            }
            else
            {
                Console.WriteLine("Digite um valor positivo");
            }
            Console.WriteLine($"Conta: {NumeroConta}\nSaldo Atual: {Saldo.ToString("C")}");
        }
    }
}
