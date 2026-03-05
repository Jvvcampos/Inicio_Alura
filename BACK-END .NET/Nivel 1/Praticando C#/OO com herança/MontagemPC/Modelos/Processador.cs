using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontagemPC.Modelos
{
    internal class Processador
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }

        public Processador(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }
    }
}
