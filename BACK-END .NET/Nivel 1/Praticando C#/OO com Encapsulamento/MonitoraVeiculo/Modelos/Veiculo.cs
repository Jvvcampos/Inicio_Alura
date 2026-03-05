using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraVeiculo.Modelos
{
    internal class Veiculo
    {
        public string Placa { get; set; }
        private double _velocidadeAtual;
        public double VelocidadeAtual 
        {
            get { return _velocidadeAtual; }
            private set
            {
                _velocidadeAtual = value;
            }

        }

        public Veiculo(string placa, double velocidadeAtual)
        {
            Placa = placa;
            _velocidadeAtual = velocidadeAtual;
        }

        public void AtualizarVelocidade(double velocidadeNova)
        {
            if(velocidadeNova < 0)
            {
                Console.WriteLine("Velocidade negativa é inválida, velocidade não alterada!");
                return;
            }
            VelocidadeAtual = velocidadeNova;
            Console.WriteLine($"Veículo: {Placa}");
            Console.WriteLine($"Velocidade atual: {VelocidadeAtual}");
        }
    }
}
