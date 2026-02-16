using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_DoWhile
{
    internal class Estoque
    {
        public static void Executar()
        {
            /*
             Imagine que você é responsável pelo setor de logística de uma loja de eletrônicos. Seu primeiro desafio é criar um sistema para 
            registrar a entrada de produtos no estoque. Como a loja recebe mercadorias diariamente, você precisa de uma ferramenta que permita 
            adicionar quantidades de forma ágil e que mostre o total acumulado, evitando erros manuais.

            Crie um programa que:

            - Pergunte ao usuário se ele deseja registrar uma nova entrada.
            - Se sim, solicitar a quantidade e atualizar o estoque.
            - Repetir o processo até que o usuário decida encerrar.
            */

            int estoque = 0;

            Console.WriteLine("Deseja adicionar um produto ao estoque?");
            Console.WriteLine("1 - Sim | 0 - Não");
            int opcao = Convert.ToInt32(Console.ReadLine());

            while(opcao != 0)
            {
                Console.WriteLine("\nQuantidade: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());
                estoque += quantidade;

                Console.WriteLine($"Estoque atual: {estoque}\n");

                Console.WriteLine("Deseja continuar?");
                Console.WriteLine("1 - Sim | 0 - Não");
                opcao = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nObrigado por usar nosso sistema de estoque!\r\n");
        }
    }
}
