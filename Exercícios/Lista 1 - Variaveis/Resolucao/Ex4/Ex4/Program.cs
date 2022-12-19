using System;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista 1 - Ex.4

            //Declaração de variáveis
            int a = 10;

            //Variável B recebe o valor de A + 2
            int b = a + 2;

            //Redefinindo o valor de A
            a = b + 1;

            //Saída da variável A
            Console.WriteLine("A = "+ a);

            //Redefinindo o valor de A
            a = b + 1;

            //Concatenação de variáveis
            Console.WriteLine($"{a}, {b}");
        }
    }
}
