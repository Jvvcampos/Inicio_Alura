using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio.Model
{
    internal class Desenvolvedor : Funcionario
    {
        public override void GerarRelatorio()
        {
            base.GerarRelatorio();
            Console.WriteLine("Relatório do desenvolvedor: escreve código e corrige bugs.\n");
        }
    }
}
