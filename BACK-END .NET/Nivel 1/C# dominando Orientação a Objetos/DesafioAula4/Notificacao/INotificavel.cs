/*
Criar uma interface chamada INotificavel com um método EnviarNotificacao. Implemente essa interface em duas classes, Email e SMS. 
O método EnviarNotificacao deve exibir mensagens diferentes para cada tipo de notificação.
*/

namespace DesafioAula4.Notificacao
{
    internal interface INotificavel
    {
        string EnviarNotificacao();
    }
}
