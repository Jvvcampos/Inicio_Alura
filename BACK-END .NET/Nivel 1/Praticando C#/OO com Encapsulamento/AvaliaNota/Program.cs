/*
Você está desenvolvendo um sistema de avaliação para uma escola. Um professor só pode atribuir notas maiores ou iguais
a 0 e menores ou iguais a 10. Nenhum outro ponto do sistema pode alterar a nota de um aluno diretamente.

Crie uma classe chamada Avaliacao com:

- Uma propriedade pública Aluno.
- Uma propriedade Nota, com get público e set privado.
- Um método público AtribuirNota(double nota) que só permita valores entre 0 e 10. 
  Se o valor for inválido, exiba uma mensagem de erro.
*/

using AvaliaNota.Modelos;

Avaliacao avaliacao = new Avaliacao("Carlao");
avaliacao.AtribuirNota(11);   // inválido
avaliacao.AtribuirNota(8.5);