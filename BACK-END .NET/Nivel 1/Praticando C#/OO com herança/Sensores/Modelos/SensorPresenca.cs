using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensores.Modelos
{
    internal class SensorPresenca : ISensor
    {
        public void Ativar()
        {
            Console.WriteLine("Sensor de presença está ativo!");
        }

        public void Desativar()
        {
            Console.WriteLine("Sensor de presença está Desativado!");
        }
    }
}
