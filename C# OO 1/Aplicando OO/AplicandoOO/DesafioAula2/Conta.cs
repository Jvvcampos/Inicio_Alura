using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula2_2
{
    /*
     * Reescrever a classe Conta, utilizando properties.
     */
    class Conta
    {
        public string Titular {  get; set; }
        public int IdConta {  get; set; }
        public float Saldo { get; set; }
        public int Senha {  get; set; }

    }
}
