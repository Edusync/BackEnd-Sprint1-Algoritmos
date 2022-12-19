using System;

namespace Lista1_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista 1 - Exercício 2

            //Declarando as variáveis
            int a = 15;
            int b = 3;

            //A variável C recebe o valor da multiplicação
            int c = a * b;

            //Saída da variável C
            Console.WriteLine(c);

            //Redefinindo o valor da variável B
            b = 10;

            //Redefinindo o valor da variável C
            c = a - b;

            //Concatenação de várias variáveis
            Console.WriteLine($"{a}, {b}, {c}");
        }
    }
}
