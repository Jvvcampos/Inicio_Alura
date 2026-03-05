/*
Imagine que você está desenvolvendo uma aplicação bancária e precisa encapsular o comportamento de um saque de dinheiro.

Por questões de segurança, a lógica de validação do saque não pode ficar dentro da própria conta, mas deve ser delegada a 
uma classe interna de segurança, responsável por validar os limites permitidos para a operação.

Crie:

* Uma classe ContaBancaria, com:

    - Propriedade pública Titular
    - Campo privado saldo
    - Construtor para definir o titular e saldo inicial
    - Método público Sacar(double valor) que só realiza o saque se a classe interna de segurança permitir
    - Propriedade Saldo (somente leitura)
* Uma classe SegurancaConta (com modificador internal), com:

    - Um método ValidarSaque(double valor) que apenas autoriza saques de até R$ 1000
*/

using ValidaSaque.Modelos;

ContaBancaria conta = new ContaBancaria("Pedro", 2500);
conta.Sacar(1500);
conta.Sacar(800);