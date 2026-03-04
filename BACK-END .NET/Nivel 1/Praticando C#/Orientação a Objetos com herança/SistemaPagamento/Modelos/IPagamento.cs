using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento.Modelos
{
    internal interface IPagamento
    {
        void ProcessarPagamento();
    }
}
