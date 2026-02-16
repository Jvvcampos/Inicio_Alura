using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_DoWhile
{
    internal class SomaVendas
    {
        public static void Executar()
        {
            /*
            Imagine que uma loja de roupas te contratou para criar um sistema simples que ajude a registrar e somar os valores das vendas diárias. 
            A loja não possui um sistema de caixa automatizado, então os funcionários precisam digitar manualmente o valor de cada venda ao final do dia. 
            O desafio é criar um programa que permita a entrada desses valores de forma contínua até que o usuário digite "0", indicando que todas as vendas 
            do dia foram registradas.

            Crie um programa que:

            - Solicite ao usuário que digite o valor de cada venda (inteiro).
            - Enquanto o valor digitado for diferente de “0”, o programa adiciona o valor ao total acumulado. O valor precisa ser solicitado ao menos uma vez antes de verificar se o loop deve continuar ou não.
            - Quando o usuário digita “0”, o programa encerra o loop e exibe o total de vendas do dia.
            */

            double totalVendas = 0;
            double vendaAtual;

            do
            {
                Console.WriteLine("Digite o valor da venda (ou 0 para encerrar): ");
                vendaAtual = Convert.ToDouble(Console.ReadLine());
                totalVendas += vendaAtual;
            }
            while (vendaAtual > 0);

            Console.WriteLine($"Total de vendas do dia: {totalVendas.ToString("C")}");
        }
    }
}
