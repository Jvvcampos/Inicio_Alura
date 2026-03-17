using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio.TemplateMethod
{
    internal class Desenvolvedor2 : Funcionario2
    {
        protected override void RelatorioFilho()
        {
            Console.WriteLine("Relatório do desenvolvedor: escreve código e corrige bugs.\n");
        }
    }
}
