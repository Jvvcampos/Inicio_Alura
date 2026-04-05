using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesafioAula4.Modelos
{
    internal class Pessoa
    {
        private static string DeskPath = "C:\\Users\\joaov\\OneDrive\\Desktop";
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public static List<Pessoa> ListaPessoas { get; private set; } = new List<Pessoa>();
        public Pessoa(string nome, int idade, string email) 
        {
            Nome = nome;
            Idade = idade;
            Email = email;
        }

        public void SerializarPessoa(Pessoa pessoa)
        {
            string nomeArq = $"{DeskPath}\\{pessoa.Nome}.json";
            string json = JsonSerializer.Serialize(pessoa);
            File.WriteAllText(nomeArq, json);
            Console.WriteLine($"Arquivo salvo em {nomeArq}\n");
        }
        public static void SerializarLista()
        {
            string nomeArq = $"{DeskPath}\\lista.json";
            string json = JsonSerializer.Serialize(ListaPessoas);
            File.WriteAllText (nomeArq, json);
            Console.WriteLine($"Lista de pessoas salva em {nomeArq}");
        }

        public static void DeserializarPessoa(string nomearq)
        {
            string arqPath = $"{DeskPath}\\{nomearq}.json";

            if (File.Exists(arqPath))
            {
                string jsonString = File.ReadAllText(arqPath);
                Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString);
                pessoa.ExibirDados();
            }
            else
            {
                Console.WriteLine("O arquivo digitado não existe!\n");
            }
        }
        public static void DeserializarLista(string nomearq)
        {
            string arqPath = $"{DeskPath}\\{nomearq}.json";

            if (File.Exists(arqPath))
            {
                string jsonString = File.ReadAllText(arqPath);
                ListaPessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);

                foreach(var pessoa in ListaPessoas)
                {
                    pessoa.ExibirDados();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("O arquivo digitado não existe!\n");
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine();
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Email: {Email}");
        }

        public static void AdicionarPessoa(Pessoa pessoa)
        {
            ListaPessoas.Add(pessoa);
        }
    }
}
