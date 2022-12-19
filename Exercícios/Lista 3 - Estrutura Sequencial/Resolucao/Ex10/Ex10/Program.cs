using System;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 9 - Lista 3
            //Declaramos e atribuimos valores as variáveis
            double custoEvento = 3000;
            double precoIngresso = 15;

            //Dividimos o custo do evento pelo valor do ingresso
            double qtdMinima = custoEvento / precoIngresso;

            //Exibimos o resultado no console
            //Esperado : 200 ingressos vendidos
            Console.WriteLine("A quantidade mínima de vendas dos ingressos deverá ser: "+qtdMinima);
        }
    }
}
