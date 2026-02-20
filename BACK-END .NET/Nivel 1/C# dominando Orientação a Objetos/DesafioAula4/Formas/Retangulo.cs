using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula4.Formas
{
    internal class Retangulo : IForma
    {
        public double Base { get; private set; }    
        public double Altura { get; private set; }    

        public Retangulo(double b, double h)
        {
            this.Base = b;
            this.Altura = h;
        }
        public double CalculaArea()
        {
            return Base * Altura;
        }

        public double CalculaPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
