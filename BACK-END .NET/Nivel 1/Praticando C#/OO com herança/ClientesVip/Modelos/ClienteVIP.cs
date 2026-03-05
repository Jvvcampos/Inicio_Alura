using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesVip.Modelos
{
    internal class ClienteVIP : Pessoa
    {
        public string Nivel { get; private set; }
        public string CodigoVip {  get; private set; }

        public ClienteVIP(string nome, int idade, string nivel, string codigo) : base(nome, idade)
        {
            this.Nivel = nivel;
            this.CodigoVip = codigo;
        }

        public override string ToString()
        {
            return $"Bem vindo, cliente VIP: {Nome}\nIdade: {Idade}\nNivel fidelidade: {Nivel}\nCódigo VIP: {CodigoVip}";
        }
    }
}
