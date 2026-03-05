using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaNota.Modelos
{
    internal class Avaliacao
    {
        public string Aluno { get; }
        public double Nota { get; private set; }

        public Avaliacao(string aluno) 
        {
            this.Aluno = aluno;
            this.Nota = Nota;
        }

        public void AtribuirNota(double nota)
        {
            if(nota >=0 && nota <= 10)
            {
                Nota = nota;
                Console.WriteLine($"Aluno: {Aluno}");
                Console.WriteLine($"Nota atribuída: {Nota}");
            }
            else
            {
                Console.WriteLine("Nota inválida!");
            }
        }
    }
}
