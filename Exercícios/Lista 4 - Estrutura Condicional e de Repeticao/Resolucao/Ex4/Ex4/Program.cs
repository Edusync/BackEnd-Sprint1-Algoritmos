using System;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 4 - Lista 4

            Console.WriteLine("Digite um valor: ");
            //Console.ReadLine() -> Lê o que o usuário digita
            //int.Parse() -> Converte string para int
            int valor = int.Parse(Console.ReadLine());

            //O valor é negativo ou positivo?
            //Se o valor for maior que zero
            if(valor > 0)
            {
                //Condição verdadeira -> Valor é positivo
                Console.WriteLine("Valor é positivo");
            } else
            {
                //Condição falsa -> Valor é negativo
                Console.WriteLine("Valor é negativo");
            }

            //O valor é par ou ímpar?
            //% -> Resto da divisão
            int resto = valor % 2;

            //Se o resto divisão por 2 é igual a zero
            if(resto == 0)
            {
                //Condição verdadeira -> Número par
                Console.WriteLine("Número par");
            } else
            {
                //Condição falsa -> Número impar
                Console.WriteLine("Número ímpar");
            }
        }
    }
}
