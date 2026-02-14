using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis_e_tipos
{
    internal class Horas
    {
        public static void Executar()
        {
            /*
             Imagine que você está desenvolvendo um sistema de gerenciamento de tempo para um aplicativo de produtividade. Esse sistema 
            precisa converter o tempo total de atividades, registrado em minutos, para um formato mais legível (horas e minutos), facilitando 
            a visualização do usuário.

            Crie um programa que:

                Declare uma variável com um valor inteiro representando o total de minutos.
                Calcule quantas horas completas existem nesse valor e quantos minutos restam.
                Exiba o resultado no formato X horas e Y minutos.
             */

            int minutos = 100;
            int horas = minutos / 60;
            int restante = minutos % 60;

            Console.WriteLine($"Tempo: {horas} horas e {restante} minutos");
        }
    }
}
