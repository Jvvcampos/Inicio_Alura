Random numeroSecreto = new Random();
int numeroAleatorio = numeroSecreto.Next(1, 101);

Console.WriteLine("Bem-vindo ao jogo do número secreto em c#!");

do
{
    Console.WriteLine("\nDigite um número entre 1 e 100:");
    string input = Console.ReadLine()!;

    if (!int.TryParse(input, out int entrada))
    {
        Console.WriteLine("Não é um número valido");
        continue;
    }

    if(entrada < 1 || entrada > 100)
    {
        Console.WriteLine("Número inválido! Tente novamente.");
        continue;
    }
    if(entrada < numeroAleatorio)
    {
        Console.WriteLine("O número tentado é menor que o número secreto!");
        continue;
    }
    if(entrada > numeroAleatorio)
    {
        Console.WriteLine("O número tentado é maior que o número secreto!");
        continue;
    }
     Console.WriteLine("Parabéns, você acertou!!!!");
     break;

} while (true);
