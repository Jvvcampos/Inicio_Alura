using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis_e_tipos
{
    internal class perimetro
    {
        public static void Executar()
        {
            /*
            Você trabalha para uma empresa de engenharia que desenvolve soluções para cálculos geométricos utilizados em projetos de construção e design.
            Um dos clientes da empresa solicitou um sistema para calcular a área e o perímetro (também conhecido como circunferência) de círculos, 
            informações essenciais para o planejamento de estruturas circulares, como tanques, pisos e jardins.

            Sua missão é criar um programa que, a partir do raio de um círculo, calcule sua área e perímetro utilizando as fórmulas matemáticas adequadas.

            Crie um programa que:

            - Declare uma variável que receba o valor de PI (considere PI como sendo igual a 3.14159).
            - Declare uma variável que receba o valor do raio do círculo.
            - Calcule e armazene em uma variável a área do círculo utilizando a fórmula: área = pi x raio x raio.
            - Calcule e armazene em uma variável o perímetro do círculo utilizando a fórmula: 2 * pi * raio.
            - Exiba os resultados no console.
             */

            double pi = 3.14159;
            double raio = 5.7;
            double areaCirculo = pi * raio * raio;
            double perimetroCirculo = 2 * pi * raio;

            Console.WriteLine($"A area do círculo é {areaCirculo} e do perimetro é {perimetroCirculo}");
        }
    }
}
