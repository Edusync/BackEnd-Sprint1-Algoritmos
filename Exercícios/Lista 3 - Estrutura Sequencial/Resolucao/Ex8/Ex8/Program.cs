using System;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 8 - Lista 3

            //Distribuidor = 30% do custo de fábrica
            //Impostos = 45% do custo de fábrica

            int custoFabrica = 50000;

            //Total Imposto = Calculamos 45% do custo de fábrica
            //0.45 = 45 / 100
            double totalImposto = 0.45 * custoFabrica;

            //Total Distribuidor = Calculamos 30% do custo de fábrica
            //0.30 = 30 / 100
            double totalDistribuidor = 0.30 * custoFabrica;

            //Custo consumidor = Custo Fabrica + Distrubuidor (porcentagem) + Impostos (porcentagem)
            double custoConsumidor = custoFabrica + totalImposto + totalDistribuidor;

            //Exibimos os resultados no console
            Console.WriteLine("O total de imposto é: " + totalImposto + " reais");
            Console.WriteLine("O total do distribuidor é: " + totalDistribuidor + "reais");
            Console.WriteLine("O total do consumidor é: " + custoConsumidor + " reais");
        }
    }
}
