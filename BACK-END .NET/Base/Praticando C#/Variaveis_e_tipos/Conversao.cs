using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis_e_tipos
{
    internal class Conversao
    {
        public static void Executar()
        {
            /*
            Imagine que você está desenvolvendo um sistema de gerenciamento de carga para um grande centro de distribuição. 
            Para otimizar o transporte, a empresa estabeleceu que cada veículo deve transportar exatamente 1 tonelada. 
            Seu sistema precisa converter o peso total dos containers para um número inteiro de veículos necessários, descartando qualquer 
            fração decimal (já que um veículo não pode ser alocado para transportar apenas parte da carga).

            Seu programa deve:

                - Receber o peso total em toneladas (decimal)
                - Converter para inteiro descartando a parte decimal
                - Exibir a quantidade mínima de veículos necessários
             */

            decimal pesoContainer = 18.75m;
            int conversao = (int)pesoContainer;
            int limiteCarga = 1;

            int qntVeiculos = conversao / limiteCarga;

            Console.WriteLine($"Seria necessário {qntVeiculos} veículos para transportar a carga de {pesoContainer}, obedecendo a otimização da empresa.");
        }
    }
}
