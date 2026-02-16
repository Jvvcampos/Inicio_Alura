using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Acesso
    {
        public static void Executar()
        {
            /*
            Imagine que você está desenvolvendo um sistema de controle de acesso para um laboratório de pesquisa altamente seguro. 
            Sua tarefa é criar um programa que valide as credenciais de quem tenta entrar, garantindo que apenas pessoas autorizadas tenham acesso.

            Crie um programa que:

            - Receba uma senha.
            - Receba um nível de acesso.
            - Verifique se:
                A senha está correta (Considere a senha como 42).
                O nível de acesso é igual ou superior a 5.
            - Exiba “Acesso liberado” se ambos os critérios forem atendidos, ou “Acesso negado” caso contrário.
            */
            string senhaCorreta = "42";
            int nivelAcessoCorreto = 5;
            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();
            Console.WriteLine("Digite o nivel de acesso: ");
            int nivelAcesso = int.Parse(Console.ReadLine());

            if(senha == senhaCorreta && nivelAcesso == nivelAcessoCorreto)
            {
                Console.WriteLine("Acesso liberado");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }
        }
    }
}
