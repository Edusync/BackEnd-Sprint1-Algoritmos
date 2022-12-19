using System;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 11 - Lista 4

            //Repete o processo 10 vezes
            for(int i = 1; i <= 10; i++)
            {
                //Contatenamos os valores
                //Fazemos a multiplicação do resultado direto na concatenação
                Console.WriteLine($"7 X {i} = {7*i}");
            }
        }
    }
}
