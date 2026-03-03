using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    internal class Funcionario
    {
        public string Nome { get; private set; }
        public string Cargo { get; private set; }
        
        public Funcionario(string nome, string cargo)
        {
            this.Nome = nome;
            this.Cargo = cargo;

            Console.WriteLine($"Funcionario: {Nome}");
            Console.WriteLine($"Cargo Atual: {Cargo}");
        }

        public void Promover(string cargo)
        {
            if(string.IsNullOrEmpty(cargo) == true)
            {
                Console.WriteLine("\nO novo cargo não pode ser nulo ou vázio!");
                return;
            }
            if(cargo == Cargo)
            {
                Console.WriteLine("\nErro: O novo cargo deve ser diferente do cargo atual.");
                return;
            }
            else
            {
                Cargo = cargo;
                Console.WriteLine("Promoção realizada com sucesso!");
                Console.WriteLine("\n--- Após promoção ---");
                Console.WriteLine($"Funcionario: {Nome}");
                Console.WriteLine($"Cargo Atual: {Cargo}");
            }
        }
    }
}
