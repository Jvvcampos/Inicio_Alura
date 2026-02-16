using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_foreach
{
    internal class PulaNumero
    {
        public static void Executar()
        {
            /*
            Você está desenvolvendo um sistema de seleção para um evento de tecnologia onde os participantes são identificados por números de 1 a 20. 
            No entanto, os números múltiplos de 3 estão reservados para uma etapa especial do evento, onde os participantes serão direcionados para 
            atividades exclusivas. Para evitar confusão, esses números não devem ser exibidos na lista inicial de participantes.

            - Sua tarefa é criar um programa que exiba todos os números de 1 a 20, mas pule os múltiplos de 3.
            */

            for(int i = 0; i < 20; i++)
            {
                if(i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
