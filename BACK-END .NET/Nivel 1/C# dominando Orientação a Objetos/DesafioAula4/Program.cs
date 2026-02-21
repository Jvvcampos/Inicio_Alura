using DesafioAula4.Formas;
using DesafioAula4.Notificacao;
using DesafioAula4.Pagamento;

/*Circulo circulo = new Circulo(10.3);
Console.WriteLine(circulo.CalculaArea());
Console.WriteLine(circulo.CalculaPerimetro());

Retangulo retangulo = new Retangulo(4, 3);
Console.WriteLine(retangulo.CalculaArea());
Console.WriteLine(retangulo.CalculaPerimetro());*/

/*Email email = new Email("teste@gmail.com", "teste", "testado");
Console.WriteLine(email.EnviarNotificacao());

SMS sms = new SMS("6299899877", "oi");
Console.WriteLine(sms.EnviarNotificacao());*/

Produto produto = new Produto("Refri", 5.80m, 4);
decimal resultProduto = produto.CalcularPagamento();
Console.WriteLine($"O valor do produto foi {resultProduto.ToString("C")}");

Servico servico = new Servico("Manutencao", 30.0m, 8);
decimal resultServico = servico.CalcularPagamento();
Console.WriteLine($"O valor do serviço foi {resultServico.ToString("C")}");