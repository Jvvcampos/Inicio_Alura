using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula1.Exercicios
{
    internal class E4
    {
        public void Executar()
        {
            try
            {
                E4_2 objetoNulo = null;
                objetoNulo.Meumetodo();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
