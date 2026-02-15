using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis_e_tipos
{
    internal class Salario
    {
        public static void Executar()
        {
            /*
             * Você trabalha desenvolvendo um sistema de recursos humanos para uma empresa. Uma das funcionalidades desse sistema é calcular o aumento salarial
             * dos funcionários com base em percentual definido pela empresa. Seu desafio é criar um programa que facilite esse cálculo.

            Crie um programa que:

                - Defina uma variável para o salário atual (decimal).
                - Defina uma variável para o percentual de aumento (decimal).
                - Calcule o novo salário e o salve em uma nova variável (decimal).
                - Por fim, exiba o novo salário.
                A fórmula para o cálculo é:
                    salarioAtual + (salarioAtual * percentualAumento / 100) 
             */

            decimal salarioAtual = 2300m;
            decimal percentualAumento = 15m;
            decimal salarioNovo = salarioAtual + (salarioAtual * percentualAumento / 100);

            Console.WriteLine($"O novo salário é de: {salarioNovo.ToString("F2")}");
        }
    }
}
