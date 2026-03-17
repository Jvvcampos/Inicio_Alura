using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio.TemplateMethod
{
    internal abstract class Funcionario2
    {
        public void GerarRelatorio()
        {
            Console.WriteLine("Bem vindo ao Gera Relatorio Template Method!");

            RelatorioFilho();
        }

        protected abstract void RelatorioFilho();
    }
}
