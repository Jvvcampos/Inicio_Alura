using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio.Model
{
    internal abstract class Funcionario
    {
        public virtual void GerarRelatorio()
        {
            Console.WriteLine("Bem vindo ao Gera Relatorio!\n");
        }
    }
}
