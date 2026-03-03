using ContaBancaria;
/*
Você foi contratado(a) para desenvolver um sistema de operações bancárias. Cada conta precisa ter um número e um saldo inicial. 
E, deve existir um método para realizar depósitos, recebendo o valor a ser depositado como parâmetro.

Crie uma classe chamada ContaBancaria que tenha:

    - Uma propriedade pública NumeroConta.
    - Uma propriedade pública Saldo.
    - Um método Depositar(double valor) que adicione o valor ao saldo existente.
    - Depois, crie uma instância da classe, realize um depósito e exiba o saldo atualizado.
*/
Conta conta = new Conta(1000.0, "7981-01");
conta.Depositar(100.00);
