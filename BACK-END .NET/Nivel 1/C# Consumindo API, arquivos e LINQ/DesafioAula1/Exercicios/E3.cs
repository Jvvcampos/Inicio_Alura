using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula1.Exercicios
{
    internal class E3
    {
        public void Executar()
        {
            List<int> inteiros = new List<int>();

            try
            {
                Console.WriteLine($"Valor: {inteiros[1]}");
            }
            catch ( Exception ex )
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
