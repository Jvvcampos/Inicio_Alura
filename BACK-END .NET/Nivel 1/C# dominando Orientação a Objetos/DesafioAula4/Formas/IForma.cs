/*
Criar uma interface chamada IForma que declare métodos para calcular a área e o perímetro de uma forma geométrica. 
Implemente esta interface em duas classes: Circulo e Retangulo.
*/

namespace DesafioAula4.Formas
{
    internal interface IForma
    {
        double CalculaArea();
        double CalculaPerimetro();
    }
}
