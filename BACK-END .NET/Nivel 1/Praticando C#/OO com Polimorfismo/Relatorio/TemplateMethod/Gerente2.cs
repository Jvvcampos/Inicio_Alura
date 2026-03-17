using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio.TemplateMethod
{
    internal class Gerente2 : Funcionario2
    {
        protected override void RelatorioFilho()
        {
            Console.WriteLine("Relatório do gerente: supervisiona a equipe.\n");
        }
    }
}
