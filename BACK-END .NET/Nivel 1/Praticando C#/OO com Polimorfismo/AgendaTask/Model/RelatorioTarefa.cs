using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTask.Model
{
    internal class RelatorioTarefa : TarefaAgendada
    {
        internal override void Executar()
        {
            Console.WriteLine("Gerando e enviando relatório diário...");
        }
    }
}
