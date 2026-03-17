using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTask.Model
{
    internal class BackupTarefa : TarefaAgendada
    {
        internal override void Executar()
        {
            Console.WriteLine("Executando tarefa de backup do sistema...");
        }
    }
}
