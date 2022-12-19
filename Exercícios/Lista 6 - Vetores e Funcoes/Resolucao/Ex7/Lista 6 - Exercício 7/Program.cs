using System;

namespace Lista_6___Exercício_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista 6 - Exercício 7

            //Declarando um vetor com 10 índices
            int[] vetor = new int[10];

            //Repetir o processo 10 vezes
            for(int i = 0; i < vetor.Length; i++)
            {
                //Pedir para o usuário digitar um valor
                Console.WriteLine("Digite um valor");
                //Receber o valor do usuário e armazenar no vetor
                vetor[i] = int.Parse(Console.ReadLine());
            }

            //Função para fazer o vetor ficar em ordem crescente
            Array.Sort(vetor);

            //Escrevendo a nova sequência
            Console.WriteLine("Nova sequência: ");
            //Repetir o mesmo número de elementos no array
            foreach(int numero in vetor)
            {
                //Mostrar resultado no console
                Console.WriteLine(numero);
            }
        }
    }
}
