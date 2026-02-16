using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Livros
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o código do livro: ");
            int codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case >=100 and <=199:
                    Console.WriteLine("Ficção Científica");
                    break;

                case >= 200 and <= 299:
                    Console.WriteLine("Literatura Clássica");
                    break;

                case >= 300 and <= 399:               
                    Console.WriteLine("Fantasia");
                    break;

                case >= 400 and <= 499:
                    Console.WriteLine("Romance");
                    break;

                case >= 500 and <= 599:
                    Console.WriteLine("Suspense/Mistério");
                    break;

                case >= 600 and <= 699:
                    Console.WriteLine("Não Ficção");
                    break;

                case >= 700 and <= 799:
                    Console.WriteLine("Biografias/Memórias");
                    break;

                case >= 800 and <= 899:
                    Console.WriteLine("Distopia");
                    break;

                case >= 900 and <= 999:
                    Console.WriteLine("Infantojuvenil");
                    break;

                default:
                    Console.WriteLine("Código inexistente");
                    break;
            }
        }
    }
}
