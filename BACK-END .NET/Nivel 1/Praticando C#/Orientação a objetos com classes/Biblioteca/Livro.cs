using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Livro
    {
        public string Autor { get; set; }
        public string Titulo {  get; set; }

        public Livro(string autor, string titulo)
        {
            this.Autor = autor;
            this.Titulo = titulo;
        }

        public override string ToString()
        {
            return $"Livro: {Titulo}\nAutor: {Autor}";
        }
    }
}
