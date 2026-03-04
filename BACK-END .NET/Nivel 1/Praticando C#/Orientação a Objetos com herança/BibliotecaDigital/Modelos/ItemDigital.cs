using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDigital.Modelos
{
    internal class ItemDigital
    {
        public string Titulo { get; private set; }

        public ItemDigital(string titulo) 
        {
            this.Titulo = titulo;
        }
    }
}
