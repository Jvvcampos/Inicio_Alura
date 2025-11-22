using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula2_2
{
    /*
     * Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.
     */
    class Produto
    {
        public string Nome {  get; set; }
        public string Marca {  get; set; }
        public double Preço {
            get => Preço;
            set
            {
                if (value < 0) Preço = 10;

                else Preço = value;
            }
        }
        public int Estoque {  
            get => Estoque;
            set
            {
                if (value < 0) Estoque = 0;

                else Estoque = value;
            } 
        }
        public string DescricaoDetalhada 
            => $"Descrição do produto: {this.Nome} {this.Marca} {this.Preço} {this.Estoque}";

    }
}
