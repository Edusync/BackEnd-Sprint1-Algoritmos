using System;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 5 - Lista 3

            //Declarando as variáveis e atribuindo valores
            int a = 5;
            int b = 2;
            int c = 3;

            //Realizando a expressão
            //Math.Pow(x, y) -> Elevar x ao valor de y 
            double x = Math.Pow((a + b), 2) + c;

            //Exibindo o resultado no console
            Console.WriteLine("O resultado da expressão é: " + x);
        }
    }
}
