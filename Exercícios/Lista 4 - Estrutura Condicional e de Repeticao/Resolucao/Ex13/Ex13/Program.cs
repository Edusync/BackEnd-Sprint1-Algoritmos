using System;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 13 - Lista 4

            //Usuário digita o valor limite
            Console.WriteLine("Digite um valor: ");
            int valorA = int.Parse(Console.ReadLine());

            //Declarando variáveis
            int soma = 0;
            int produto = 1;

            //Repetir o processo de 1 até o valor limite
            for(int i = 1; i <= valorA; i++)
            {
                //Se o número for par
                if(i % 2 == 0)
                {
                    //Somando o número par
                    soma = soma + i;
                } 
                //Se o número for ímpar
                else
                {
                    //Multiplicando o número ímpar
                    produto = produto * i;
                }
            }

            //Exibindo o resultado no console
            Console.WriteLine("A soma dos números pares é: " + soma);
            Console.WriteLine("A multiplicação dos número ímpares é: " + produto);
        }
    }
}
