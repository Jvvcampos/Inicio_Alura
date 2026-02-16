using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Produtos
    {
        public static void Executar()
        {
            /*
            Imagine que você está desenvolvendo um sistema de gestão de estoque para um centro de distribuição de alimentos. 
            Seu desafio é criar um programa que classifique os produtos conforme seu tipo, para otimizar o armazenamento em áreas específicas do armazém.

            Crie um programa que:

                - Receba um código numérico (1 ou 2) representando o tipo de produto.
                - Classifique o produto como:
                    “Perecível” para código 1.
                    “Não perecível” para código 2.
                - Alerte o usuário caso o código seja inválido.
             */

            Console.WriteLine("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            if(codigo == 1)
            {
                Console.WriteLine("Perecível");
            }
            else if(codigo == 2)
            {
                Console.WriteLine("Não perecível");
            }
        }
    }
}
