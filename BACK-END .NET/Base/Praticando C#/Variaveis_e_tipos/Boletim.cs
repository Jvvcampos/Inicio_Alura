using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Variaveis_e_tipos
{
    internal class Boletim
    {
        public static void Executar()
        {
            /*
             Imagine que você está desenvolvendo um sistema de boletim escolar para uma escola que deseja modernizar sua forma de acompanhar o desempenho dos alunos. 
             O objetivo é criar um programa capaz de calcular a média das notas, facilitando o trabalho e fornecendo resultados imediatos.

             Para essa atividade, você deve criar um programa que:

                Declare três variáveis do tipo float para armazenar as notas dos alunos. Foi fornecido pela escola os seguintes valores (7.2, 8.3 e 9.1)
                Calcule a média aritmética das três.
                Exiba a média calculada.
            */

            float n1 = 10f;
            float n2 = 7.5f;
            float n3 = 9.0f;
            float media = (n1 + n2 + n3) / 3;

            Console.WriteLine($"A media do aluno foi de {media}");
        }
    }
}
