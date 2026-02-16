using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_foreach
{
    internal class Multiplicacao
    {
        public static void Executar()
        {
            /*
            Imagine que você está criando um programa para mostrar a tabela de multiplicação de um número específico. Neste exercício, 
            o número escolhido será o 7, e a ideia é gerar a tabela de multiplicação de 7, de 1 até 10, usando um laço de repetição. 
            O que você deve fazer é escrever um programa que utilize um laço de repetição para imprimir a tabela de multiplicação do número 7. .
            */

            int numero = 7;

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"7 X {i} = {numero*i}");
            }
        }
    }
}
