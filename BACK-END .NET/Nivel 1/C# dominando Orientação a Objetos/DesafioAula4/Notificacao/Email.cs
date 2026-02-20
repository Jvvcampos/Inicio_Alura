using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula4.Notificacao
{
    internal class Email : INotificavel
    {
        public string Endereco { get; private set; }
        public string Assunto { get; private set; }
        public string Texto { get; private set; }

        public Email(string endereco, string assunto, string texto)
        {
            this.Endereco = endereco;
            this.Assunto = assunto;
            this.Texto = texto;
        }

        public string EnviarNotificacao()
        {
            return $"Email enviado para {Endereco} com assunto: {Assunto}. Contendo a seguinte mensagem: {Texto}";
        }
    }
}
