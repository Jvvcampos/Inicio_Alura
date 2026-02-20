using DesafioAula4.Formas;
using DesafioAula4.Notificacao;

/*Circulo circulo = new Circulo(10.3);
Console.WriteLine(circulo.CalculaArea());
Console.WriteLine(circulo.CalculaPerimetro());

Retangulo retangulo = new Retangulo(4, 3);
Console.WriteLine(retangulo.CalculaArea());
Console.WriteLine(retangulo.CalculaPerimetro());*/

Email email = new Email("teste@gmail.com", "teste", "testado");
Console.WriteLine(email.EnviarNotificacao());

SMS sms = new SMS("6299899877", "oi");
Console.WriteLine(sms.EnviarNotificacao());

