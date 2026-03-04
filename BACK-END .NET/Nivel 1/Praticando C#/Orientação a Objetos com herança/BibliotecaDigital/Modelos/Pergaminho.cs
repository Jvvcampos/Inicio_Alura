using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDigital.Modelos
{
    internal class Pergaminho : ItemDigital
    {
        public string Texto { get; set; }

        public Pergaminho(string titulo, string texto) : base(titulo) 
        {
            this.Texto = texto;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine("Detalhes do pergaminho:");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Conteúdo: {Texto}");
        }
    }
}
