using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula2_2
{
    /*
     * 2)Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
     * 3)Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
     */
    class Carro
    {
        private int ano;
        public string Fabricante {  get; set; }
        public string Modelo {  get; set; }
        public int Ano { 
            get => ano;
            set
            {
                if(value < 1960 || value > 2023)
                {
                    Console.WriteLine("Valor inválido, deve estar entre 1960 e 2023");
                }
                else
                {
                    Ano = value;
                }
            } 
        }
        public int QuantidadePortas {  get; set; }
        public string DescricaoDetalhada => $"Modelo do carro:{this.Fabricante} {this.Modelo} {this.Ano} {this.QuantidadePortas}";
    }
}
