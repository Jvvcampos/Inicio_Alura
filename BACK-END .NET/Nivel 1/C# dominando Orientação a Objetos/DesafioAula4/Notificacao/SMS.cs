using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula4.Notificacao
{
    internal class SMS : INotificavel
    {
        public string Numero { get; private set; }
        public string Mensagem { get; private set; }

        public SMS(string numero, string mensagem)
        {
            this.Numero = numero;
            this.Mensagem = mensagem;
        }
        public string EnviarNotificacao()
        {
            return $"A mensagem: {Mensagem} foi enviada para o número {Numero}";
        }
    }
}
