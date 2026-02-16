using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Recompensa
    {
        public static void Executar()
        {
            /*
            Imagine que você está desenvolvendo um sistema de missões para um jogo medieval. Os jogadores podem resgatar cupons secretos 
            encontrados em baús ou derrotando inimigos para obter recompensas exclusivas. Cada cupom desbloqueia um benefício diferente.

            Crie um programa que:

            - Receba o cupom de recompensa inserido
            - Retorne uma mensagem de acordo com o cupom
            - Informe que “Recompensa indisponível” se o cupom for inválido
            - As recompensas de acordo com o cupom são:

                DOBRAR: Ganhar 2x EXP por 1 hora.
                CURAR: Poção de cura.
                OURO: 1000 moedas de ouro.
                ESPECIAL: Item lendário.
            Sua tarefa é usar a sintaxe simplificada do switch-case para retornar a mensagem diretamente na atribuição da variável, 
            tornando o código mais conciso e legível.
            */

            Console.WriteLine("Digite o cupom de recompensa: ");
            string cupom = Console.ReadLine();

            switch (cupom)
            {
                case "DOBRAR":
                    Console.WriteLine("Ganhar 2x EXP por 1 hora");
                    break;
                case "CURAR":
                    Console.WriteLine("Poção de cura");
                    break;
                case "OURO":
                    Console.WriteLine("1000 Moedas de ouro");
                    break;
                case "ESPECIAL":
                    Console.WriteLine("Item lendário");
                    break;

                default:
                    Console.WriteLine("Cupom inválido");
                    break;
            }
        }
    }
}
