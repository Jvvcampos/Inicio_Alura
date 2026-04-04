using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula3.Exercicios
{
    internal class E2
    {
        class Livro
        {
            public string Nome { get; set; }
            public string Autor { get; set; }
            public int Ano { get; set; }
        }

        public void Executar()
        {
            List<Livro> livros = new List<Livro>
            {
                new Livro {Nome = "LIVRO 1", Autor = "JOAOV", Ano = 2023 },
                new Livro {Nome = "LIVRO 2", Autor = "JOAOV", Ano = 2024 },
                new Livro {Nome = "LIVRO 3", Autor = "JOAOV", Ano = 2023 },
                new Livro {Nome = "LIVRO 4", Autor = "JOAOV", Ano = 2000 },
                new Livro {Nome = "LIVRO 5", Autor = "JOAOV", Ano = 1987 },
                new Livro {Nome = "LIVRO 6", Autor = "JOAOV", Ano = 1976 },
            };

            var LivrosPorAno = livros.Where(livro => livro.Ano >= 2000).OrderBy(livro => livro.Nome).
                Select(livro => livro.Nome).Distinct().ToList();
            Console.WriteLine("Lista de livros ordenados após o ano 2000:");

            foreach (var livro in LivrosPorAno)
            {
                Console.WriteLine($"- {livro}");
            }

        }
    }
}
