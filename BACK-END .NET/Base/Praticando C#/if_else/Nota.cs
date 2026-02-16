using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Nota
    {
        public static void Executar()
        {
            /*
            Você é responsável pelo desenvolvimento do sistema de avaliação de uma escola de tecnologia. Seu programa precisa analisar o 
            desempenho dos alunos em cada módulo e atribuir uma classificação que reflita seu aproveitamento.

            Crie um sistema que:

                - Receba a nota final do aluno
                - Classifique o desempenho conforme a tabela:
                    A (notas ≥ 9)
                    B (notas ≥ 7 e < 9)
                    C (notas ≥ 5 e < 7)
                    D (notas < 5)
                - Exiba a classificação obtida.
            */
            Console.WriteLine("Digite a nota final do aluno: ");
            double notaFinal = double.Parse(Console.ReadLine());

            if (notaFinal >= 9)
            {
                Console.WriteLine("O aluno recebeu a nota A");
            }
            else if(notaFinal >= 7 && notaFinal < 9)
            {
                Console.WriteLine("O aluno recebeu a nota B");
            }
            else if(notaFinal >= 5 && notaFinal < 7)
            {
                Console.WriteLine("O aluno recebeu a nota C");
            }
            else
            {
                Console.WriteLine("O aluno recebeu a nota D");
            }
        }
    }
}
