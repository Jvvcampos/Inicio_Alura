/*
 * Criar um programa que permite ao usuário inserir informações de uma pessoa (nome, idade, e e-mail), serializa essas informações em formato JSON 
   e salva em um arquivo.
 * Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, desserializa essas informações e exibe na tela.
 * Criar um programa que permite ao usuário inserir informações de várias pessoas, armazena essas informações em uma lista, 
   serializa a lista em formato JSON e salva em um arquivo.
 * Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, desserializa essas informações em uma lista e exibe na tela.
 */
using DesafioAula4.Modelos;

while (true)
{
    Console.WriteLine("Opções:");
    Console.WriteLine(" 1 - Para criar uma pessoa e salvar o arquivo");
    Console.WriteLine(" 2 - Para ler o arquivo de uma pessoa");
    Console.WriteLine(" 3 - Para criar uma lista de pessoas");
    Console.WriteLine(" 4 - Para ler o arquivo de uma lista de pessoas");
    Console.WriteLine(" 9 - Encerrar\n");

    Console.Write("Digite sua escolha: ");
    int escolha = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (escolha)
    {
        case 1:
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o email: ");
            string email = Console.ReadLine();
            Pessoa pessoa = new Pessoa(nome, idade, email);

            pessoa.SerializarPessoa(pessoa);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu!");
            Console.ReadKey();
            Console.Clear();
            break;

        case 2:
            Console.Write("Digite o nome da pessoa: ");
            string nomeArq = Console.ReadLine();

            Pessoa.DeserializarPessoa(nomeArq);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu!");
            Console.ReadKey();
            Console.Clear();
            break;

        case 3:
            while (true)
            {
                Console.Write("Digite o nome da pessoa ou 'sair' para parar:");
                string nomeLista = Console.ReadLine();

                if (nomeLista.Equals("sair"))
                {
                    break;
                }
                Console.Write("Digite a idade: ");
                int idadeLista = int.Parse(Console.ReadLine());
                Console.Write("Digite o email: ");
                string emailLista = Console.ReadLine();
                Console.WriteLine();
                Pessoa pessoaLista = new Pessoa(nomeLista, idadeLista, emailLista);
                Pessoa.AdicionarPessoa(pessoaLista);
            }

            if (Pessoa.ListaPessoas.Any())
            {
                Pessoa.SerializarLista();
                Console.WriteLine("Digite qualquer tecla para voltar ao menu!");
                Console.ReadKey();
                Console.Clear();
            }

            break;

        case 4:
            Console.Write("Digite o nome da lista: ");
            string nomeArqLista = Console.ReadLine();

            Pessoa.DeserializarLista(nomeArqLista);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu!");
            Console.ReadKey();
            Console.Clear();
            break;
            break;
        case 9:
                Console.WriteLine("Encerrando, até!");
                return;
            }
}