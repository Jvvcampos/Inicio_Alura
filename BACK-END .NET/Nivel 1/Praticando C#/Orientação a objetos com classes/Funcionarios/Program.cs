using Funcionarios;
/*
Você está desenvolvendo um sistema de gestão de pessoas para uma empresa. O sistema precisa cadastrar funcionários informando o nome e o cargo no momento da criação. 
E, ele deve permitir que um funcionário seja promovido para um novo cargo, mas apenas se o novo cargo for diferente do atual — não faria sentido uma promoção que não
mudasse o cargo da pessoa, concorda?!

Crie uma classe chamada Funcionario que tenha:

    - Uma propriedade pública Nome.
    - Uma propriedade pública Cargo.
    - Um construtor que receba nome e cargo como parâmetros obrigatórios.
    - Um método chamado Promover(string novoCargo) que atualize o cargo do funcionário, somente se o novo cargo for diferente do atual. Se for o mesmo, exiba uma mensagem de erro informando que a promoção não pode ocorrer.
    - Depois, crie uma instância da classe, exiba os dados iniciais, promova o funcionário e exiba os dados atualizados.
*/

Funcionario funcionario = new Funcionario("Alberto", "Assistente TI");
funcionario.Promover("Dev JR");
funcionario.Promover("Dev JR");
funcionario.Promover("");
