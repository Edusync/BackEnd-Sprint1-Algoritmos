using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista 6 - Exercício 1

            //Declarar um array de 8 posições
            double[] vetor = new double[8];

            //Repetição até o tamanho do vetor (8)
            for(int i = 0; i < 8; i++)
            {
                //Math.Pow -> Calcula um número elevado a outro
                //Armazenamos no vetor[i] o Cubo do Índice
                vetor[i] = Math.Pow(i, 3);
                //Mostramos o valor de cada índice
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
