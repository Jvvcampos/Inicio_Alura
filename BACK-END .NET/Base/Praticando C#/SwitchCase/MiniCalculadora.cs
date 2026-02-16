using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class MiniCalculadora
    {
        public static void Executar()
        {
            /*
            Você precisa construir uma minicalculadora que realiza uma operação matemática com dois números. O usuário deve digitar o primeiro 
            número, o segundo número e qual operação deseja fazer: soma (+), subtração (-), multiplicação (*) ou divisão (/). 
            Com base na operação digitada, o programa deve calcular e exibir o resultado.

            Crie um programa que:

            - Receba dois números digitados pelo usuário.
            - Pergunte qual a operação matemática deseja realizar (+, -, *, /).
            - Exiba “Operação inválida” caso a entrada seja diferente das operações acima.
            - Exiba o resultado de acordo com a operação escolhida.
            */

            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a operação (+, -, *, /):");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "+":
                    double resultado = num1 + num2;
                    Console.WriteLine(resultado);
                    break;
                case "-":
                    double resultado2 = num1 - num2;
                    Console.WriteLine(resultado2);
                    break;
                case "*":
                    double resultado3 = num1 * num2;
                    Console.WriteLine(resultado3);
                    break;
                case "/":
                    double resultado4 = num1 / num2;
                    Console.WriteLine(resultado4);
                    break;

                default:
                    Console.WriteLine("Opção ínválida");
                    break;
            }
        }
    }
}
