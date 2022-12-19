using System;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 4 - Lista 3
            int ladoTriangulo = 3;

            //Primeiro calculamos a altura do triângulo equilátero
            //altura = (lado * raiz de 3) / 2
            double altura = (ladoTriangulo * Math.Sqrt(3)) / 2;

            //Agora vamos calcular a área do triângulo
            //area = (base * altura) / 2
            double area = (ladoTriangulo * altura) / 2;

            //Resultado esperado = 3.8971
            Console.WriteLine("A área do triângulo é: "+ area);
        }
    }
}
