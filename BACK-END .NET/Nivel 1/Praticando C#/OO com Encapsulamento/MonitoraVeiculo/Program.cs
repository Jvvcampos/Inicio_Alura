using MonitoraVeiculo.Modelos;
/*
Você está criando um sistema de monitoramento de veículos para uma empresa de transporte. A classe Veiculo precisa controlar a velocidade atual, 
mas a empresa quer garantir que ninguém consiga alterar diretamente esse valor, para evitar fraudes. O valor só pode ser alterado através de um 
método autorizado.

Crie uma classe chamada Veiculo que tenha:

- Uma propriedade pública Placa.
- Um campo privado velocidadeAtual.
- Um método público AtualizarVelocidade(double novaVelocidade) que atualize a velocidade.
- Uma propriedade pública de leitura (get) chamada VelocidadeAtual que retorne a velocidade atual.
*/

Veiculo veiculo = new Veiculo("ABC-134", 0);
veiculo.AtualizarVelocidade(-10.8);
veiculo.AtualizarVelocidade(30);