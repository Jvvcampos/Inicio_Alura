using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula1.Exercicios
{
    internal class E2
    {
        public void Executar()
        {
            Console.Write("Digite o valor de A");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B");
            int b = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine($"O resultado da divisao é: {a/b}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
