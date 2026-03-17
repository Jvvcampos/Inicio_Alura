using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificacao.Model
{
    internal class Email : INotificacao
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando Email: {mensagem}");
        }
    }
}
