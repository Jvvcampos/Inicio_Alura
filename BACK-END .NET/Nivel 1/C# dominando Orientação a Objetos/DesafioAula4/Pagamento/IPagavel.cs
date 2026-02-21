/*
Criar uma interface chamada IPagavel com um método CalcularPagamento. Implemente essa interface em duas classes, Produto e Servico. 
O método CalcularPagamento deve retornar o valor total a ser pago, levando em consideração a quantidade para produtos e a taxa horária para serviços.
*/

namespace DesafioAula4.Pagamento
{
    internal interface IPagavel
    {
        decimal CalcularPagamento();
    }
}
