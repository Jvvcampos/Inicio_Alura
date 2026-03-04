using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontagemPC.Modelos
{
    internal class Computador
    {
        public PlacaMae PlacaMae { get; private set; }
        public Processador Processador { get; private set; }

        public Computador(PlacaMae placaMae, Processador processador)
        {
            this.PlacaMae = placaMae;
            this.Processador = processador;
        }

        public void ExibirConfiguracao()
        {
            Console.WriteLine("Computador configurado com:");
            Console.WriteLine($"Processador: {Processador.Marca} - {Processador.Modelo}");
            Console.WriteLine($"Placa-mãe: {PlacaMae.Fabricante} - {PlacaMae.Socket}");
        }
    }
}
