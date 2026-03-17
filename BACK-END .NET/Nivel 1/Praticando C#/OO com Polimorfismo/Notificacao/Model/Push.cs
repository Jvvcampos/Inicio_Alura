using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificacao.Model
{
    internal class Push : INotificacao
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando Push: {mensagem}");
        }
    }
}
