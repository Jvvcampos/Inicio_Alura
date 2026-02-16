using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_DoWhile
{
    internal class NumSecreto
    {
        public static void Executar()
        {
            /*
             Imagine que você está desenvolvendo um jogo onde o jogador deve tentar adivinhar qual é o número secreto. 
            O desafio é criar um programa que continue solicitando tentativas até que o jogador acerte o número, fornecendo feedback a cada tentativa.

            Crie um programa que:

            - Declare uma variável com um inteiro para ser o número secreto.
            - Verifique a cada interação se o número digitado é igual ao número secreto.
            - Se o jogador errar, o programa informa que a tentativa está errada e solicita uma nova tentativa.
            - Se o jogador acertar o número, o programa exibe uma mensagem de parabéns e encerra o jogo.
            */

            int numSecreto = 9;

            Console.WriteLine("Tente adivinhar o número entre 1 e 10: ");
            int tentativa = Convert.ToInt32(Console.ReadLine());

            while(tentativa != numSecreto)
            {
                Console.WriteLine("Você errou, tente novamente!");
                tentativa = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Parabéns, você acertou!");
        }
    }
}
