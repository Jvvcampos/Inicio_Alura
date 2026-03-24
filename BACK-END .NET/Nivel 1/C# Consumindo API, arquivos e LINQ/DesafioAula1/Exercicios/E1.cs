using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace DesafioAula1.Exercicios
{
    internal class E1
    {
        public async void Executar()
        {
            HttpClient client = new HttpClient();
            string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
            Console.WriteLine(resposta);
        }
    }
}
