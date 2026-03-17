/*
Imagine que você está construindo um sistema de RH que gera relatórios personalizados. Você criou uma classe base chamada Funcionario, 
e duas subclasses: Gerente e Desenvolvedor. Cada tipo de funcionário deve gerar um relatório diferente, sobrescrevendo um método chamado 
GerarRelatorio().

- Crie essas três classes com um método public virtual string GerarRelatorio() na base, e sobrescreva esse método nas classes filhas.
*/

using Relatorio.Model;
using Relatorio.TemplateMethod;

Funcionario gerente1 = new Gerente();
Funcionario dev1 = new Desenvolvedor();

gerente1.GerarRelatorio();
dev1.GerarRelatorio();

//TEMPLATE METHOD
Console.WriteLine("A mesma coisa mas testei o conceito de template method: ");

Funcionario2 gerente2 = new Gerente2();
Funcionario2 dev2 = new Desenvolvedor2();

gerente2.GerarRelatorio();
dev2.GerarRelatorio();
