using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTask.Model
{
    internal class LimpezaTarefa : TarefaAgendada
    {
        internal override void Executar()
        {
            Console.WriteLine("Limpando arquivos temporários do servidor...");
        }
    }
}
