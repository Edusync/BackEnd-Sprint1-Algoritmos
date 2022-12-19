using System;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 10 - Lista 4

            Console.WriteLine("Digite o número inicial: ");
            int valorInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número final: ");
            int valorFinal = int.Parse(Console.ReadLine());

            //Repetição desde o valor inicial até o valor final
            for(int i = valorInicial; i <= valorFinal; i++)
            {
                //Se não tiver resto da divisão sobre dois
                if(i % 2 == 0)
                {
                    //Escrever o número par no console
                    Console.WriteLine(i);
                }
            }
        }
    }
}
