using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaSaque.Modelos
{
    internal class SegurancaConta
    {
        public static bool ValidarSaque(double valor)
        {
            if (valor <= 1000)
            {
                return true;
            }
            return false;
        }
    }
}
