using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis_e_tipos
{
    internal class Doacao
    {
        /*Você foi contratado por uma empresa beneficente, que recebe doações de pessoas físicas e jurídicas para ajudar comunidades carentes. 
        Algumas dessas doações são anônimas, e outras são registradas com os dados do doador. Além disso, as doações são depositadas em dois 
        tipos de contas: corrente ou poupança. Recentemente, uma doação anônima no valor de R$500 foi feita para a conta poupança da empresa.
        
        Crie um programa que:

            Declare uma variável para armazenar o valor recebido da doação.
            Declare uma variável para indicar se a doação foi anônima (true para anônima, false para não anônima).
            Declare uma variável para indicar o tipo de conta onde o valor foi depositado:
                Use P para conta poupança.
                Use C para conta corrente
         */
        public static void Executar()
        {
            double valorDoacao = 500.0;
            bool doacaoAnonima = true;
            char tipoConta = 'P';

            Console.WriteLine($"Valor recebido: {valorDoacao}");
            Console.WriteLine($"Doação Anonima: {doacaoAnonima}");
            Console.WriteLine($"Tipo de conta: {tipoConta}");
        }
    }
}
