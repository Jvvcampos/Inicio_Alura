using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula4.Formas
{
    internal class Circulo : IForma
    {
        public double Raio {  get; private set; }

        public Circulo(double raio)
        {
            this.Raio = raio;
        }
        public double CalculaArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public double CalculaPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }
}
