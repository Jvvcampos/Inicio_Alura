using ClientesVip.Modelos;
/*
Você está desenvolvendo um sistema para um clube, onde a experiência do cliente é prioridade. Os membros comuns têm acesso básico, 
mas os clientes VIP possuem benefícios exclusivos, como níveis de fidelidade e identificadores personalizados. Seu desafio é criar uma 
estrutura que diferencie esses perfis.

Crie um programa que:

Defina uma classe Pessoa com os atributos Nome e Idade.
Crie uma classe ClienteVIP que herde de Pessoa, adicionando:

Um atributo nível de fidelidade (ex: Ouro, Diamante).
Um atributo código VIP (ex: VIP123A).

Instancie dois clientes VIP com dados fictícios.
Exiba no console uma mensagem formatada para cada cliente, incluindo:

Uma saudação personalizada (ex: "Bem-vindo, cliente VIP: [Nome]").
Idade, nível de fidelidade e código VIP em linhas separadas.
*/
ClienteVIP cliente1 = new ClienteVIP("JOAO", 23, "ROSE", "ROS3V1P01");
Console.WriteLine(cliente1.ToString());