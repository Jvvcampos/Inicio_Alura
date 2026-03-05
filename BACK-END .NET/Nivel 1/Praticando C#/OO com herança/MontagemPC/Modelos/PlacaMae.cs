using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontagemPC.Modelos
{
    internal class PlacaMae
    {
        public string Fabricante { get; private set; }
        public string Socket { get; private set; }

        public PlacaMae(string fabricante, string socket)
        {
            this.Fabricante = fabricante;
            this.Socket = socket;
        }
    }
}
