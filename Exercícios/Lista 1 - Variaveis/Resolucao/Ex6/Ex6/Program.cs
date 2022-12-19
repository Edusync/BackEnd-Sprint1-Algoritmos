using System;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista 1 - Exercício 6

            //Declaração de variáveis
            int a = 2;
            int b = 3;

            //Redefinindo variável A
            a = a + b;

            //Variável C recebe o valor da subtração
            int c = a - b;

            //Saída dos valores
            Console.WriteLine($"{a}, {b}, {c}");
        }
    }
}
