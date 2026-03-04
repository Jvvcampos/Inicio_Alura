using SistemaPagamento.Modelos;
/*
Você está desenvolvendo um sistema para processar diferentes tipos de pagamento em uma loja online. 
Cada pagamento é feito por uma pessoa (cliente), mas o tipo de transação varia: pode ser via cartão de crédito, boleto, ou outro meio.

O sistema precisa garantir que todo tipo de pagamento execute um método chamado ProcessarPagamento(), mas cada um com uma lógica diferente. 
Além disso, as pessoas envolvidas na transação têm dados em comum.

Seu desafio é combinar herança (para modelar as pessoas) e interfaces (para padronizar os métodos de pagamento).

Crie um programa que:

- Defina uma classe base Pessoa com os atributos Nome e Email.
- Crie uma interface IPagamento com o método ProcessarPagamento().
- Crie duas classes:
    PagamentoCredito, que herda de Pessoa e implementa IPagamento.
    PagamentoBoleto, que também herda de Pessoa e implementa IPagamento.
- Em cada classe de pagamento, personalize o método ProcessarPagamento() com uma mensagem diferente.
- Instancie um cliente para cada tipo de pagamento e chame o método ProcessarPagamento().
*/

PagamentoCredito cliente1 = new PagamentoCredito("Joao", "joao@email.com", 300m);
PagamentoBoleto cliente2 = new PagamentoBoleto("Lucas", "juliana@email.com", 975.30m);

cliente1.ProcessarPagamento();
cliente2.ProcessarPagamento();