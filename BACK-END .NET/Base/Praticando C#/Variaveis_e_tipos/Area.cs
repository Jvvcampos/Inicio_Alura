using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis_e_tipos
{
    internal class Area
    {
        public static void Executar()
        {
            /*
             * Você foi contratado por uma empresa de construção civil. A empresa está expandindo os seus projetos e precisa de um 
                sistema para calcular a área de terrenos retangulares. Para isso utilize a fórmula:

                        área = largura * comprimento 

            Para essa atividade, você deve criar um programa que:

                - Declare duas variáveis para a largura e comprimento, respectivamente.
                - Aplique a fórmula mencionada para calcular a área do terreno.
                - Exiba o resultado do cálculo.
             */

            double largura = 10.2;
            double comprimento = 25.7;
            double area = largura * comprimento;

            Console.WriteLine($"A área do terreno é de {area} metros quadrados!");
        }
    }
}
