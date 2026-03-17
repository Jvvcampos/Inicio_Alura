using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio.Model
{
    internal class Gerente : Funcionario
    {
        public override void GerarRelatorio()
        {
            base.GerarRelatorio();
            Console.WriteLine("Relatório do gerente: supervisiona a equipe.");
        }
    }
}
