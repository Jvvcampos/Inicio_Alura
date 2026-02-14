using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis_e_tipos
{
    internal class Distancia
    {
        /*Você trabalha para uma empresa de turismo que organiza passeios e viagens internacionais. Muitos dos destinos oferecidos pela empresa 
        utilizam o sistema imperial de medidas, onde as distâncias são fornecidas em milhas. No entanto, os clientes brasileiros estão mais familiarizados 
        com o sistema métrico, que utiliza quilômetros.

        Para facilitar a comunicação com os clientes, sua missão é criar um sistema de conversão de distâncias que transforme milhas em quilômetros, utilizando a fórmula:
        Crie um programa que:
        
        Declare uma variável que receba o valor das milhas.
        Calcule a distância em quilômetros e armazene o resultado em uma nova variável.
        Exiba o resultado no console.
         */
        public static void Executar()
        {
            double milhas = 10.0;
            double distanciaKM = milhas * 1.60934;

            Console.WriteLine($"{milhas} milhas equivalem à {distanciaKM} quilometros");
        }
    }
}
