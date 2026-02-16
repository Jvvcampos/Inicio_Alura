using For_foreach;
/* Código da revisão
//for normal
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("A contagem chegou ao fim!");

//for com break e continue
List<string> funcionarios = new List<string>
        {
            "João-Gerente-8500",
            "Maria-Analista de Sistemas-6200",
            "Carlos-Desenvolvedor-5500",
            "Ana-Designer-4800",
            "Pedro-Suporte Técnico-3900",
            "Fernanda-Coordenadora de Projetos-7300",
            "Ricardo-Contador-6000",
            "Juliana-RH-4500"
        };

for (int i = 0; i < funcionarios.Count; i++)
{
    var salario = funcionarios[i].Split("-")[2];
    var salarioInt = int.Parse(salario);
    if (nome.Equals("Fernanda"))
    {
        Console.WriteLine($"Dados do funcionário buscado: {funcionarios[i]}");
        break;
    }
}
//foreach
// código omitido

foreach (string funcionario in funcionarios)
{
    var nome = funcionario.Split("-")[0]; 
    if (nome.Equals("Fernanda"))
    {
        Console.WriteLine($"Dados do funcionário buscado: {funcionario}");
        break;
    }
}
*/

//PulaNumero.Executar();
//Multiplicacao.Executar();
Nota.Executar();