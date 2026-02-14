using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis_e_tipos
{
    internal class Idade
    {
        /*Imagine que você está desenvolvendo um sistema para um cadastro de usuários. Uma das funcionalidades desse sistema é calcular a idade do usuário 
        para oferecer conteúdo e serviços adequados à sua faixa etária. Escreva um programa em C# que, a partir do ano de nascimento de uma pessoa, 
        calcule a idade com base no ano atual.
         */
        public static void Executar()
        {
            int anoNascimento = 1990;
            int anoAtual = 2026;

            int idade = anoAtual - anoNascimento;

            Console.WriteLine(idade);
        }
    }
}
