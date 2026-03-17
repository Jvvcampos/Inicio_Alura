/*
Você está construindo uma aplicação de alertas corporativos. Para facilitar a expansão do sistema, você decide 
criar uma estrutura onde cada canal de notificação (e-mail, SMS, push, etc.) implementa uma interface comum chamada INotificacao.

Cada tipo de notificação deve implementar o método EnviarMensagem(string mensagem) de forma específica. 
Depois, você deverá criar uma lista com diferentes notificadores e percorrê-la chamando o método de envio.
*/

using Notificacao.Model;

List<INotificacao> notificacoes = new List<INotificacao>
{
    new Email(),
    new SMS(),
    new Push()
};

foreach(var notificacao in notificacoes)
{
    notificacao.EnviarMensagem("ERRO NO ENVIO, SEM REDE!");
}