using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula3.Exercicios
{
    internal class E1
    {
        public void Executar()
        {
            List<int> inteiros = new List<int> {1, 2, 3, 4, 4, 2};

            var NumerosUnicos = inteiros.Distinct();

            Console.WriteLine("Números únicos da lista:");

            foreach(int num in NumerosUnicos)
            {
                Console.WriteLine(num + " ");
            }
        }
    }
}
