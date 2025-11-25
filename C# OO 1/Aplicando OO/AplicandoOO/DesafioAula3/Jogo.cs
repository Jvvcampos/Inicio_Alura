using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula3
{
    class Jogo
    {
        public Jogo(string nome, string genero, int anoLancamento)
        {
            this.Nome = nome;
            this.Genero = genero;
            this.AnoLancamento = anoLancamento;
        }

        public string Nome {  get; set; }
        public string Genero { get; set; }
        public int AnoLancamento { get; set; }

    }

    class CatalogoJogos
    {
        private List<Jogo> jogos = new List<Jogo>();

        public CatalogoJogos()
        {
            jogos = new List<Jogo>();
        }

        public bool CatalogoVazio => jogos.Count == 0;

        public void AdicionarJogo(Jogo jogo)
        {
            jogos.Add(jogo);
            Console.WriteLine($"Jogo {jogo.Nome} foi adicionado na lista");
        }

        public void AdicionarJogo(string nome, string genero, int anoLancamento)
        {
            Jogo jogo = new Jogo(nome, genero, anoLancamento);
            jogos.Add(jogo);
            Console.WriteLine($"Jogo {nome} foi adicionado na lista");

        }

        public void ListarJogos()
        {
            if (CatalogoVazio)
            {
                Console.WriteLine("O catalogo está vázio, você pode listar jogos agora");
            }
            else
            {
                Console.WriteLine("Catalogo de jogos: ");
                foreach(Jogo jogo in jogos)
                {
                    Console.WriteLine($"Nome: {jogo.Nome} Genero: {jogo.Genero} Ano: {jogo.AnoLancamento}");
                }
            }
        }
    }
}
