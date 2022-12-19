using System;

namespace Lista_6___Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando o vetor A com 10 índices
            int[] a = new int[10];

            //Repetir o processo até 9 -> a.length é o tamanho do vetor
            for (int i = 0; i <= a.Length - 1; i++)
            {
                //Pedindo para o usuário digitar o valor para o índice
                Console.WriteLine($"Insira o valor para o índice {i}: ");
                //Lendo e armazenando o valor no array
                a[i] = int.Parse(Console.ReadLine());

            }

            //Pedindo para o usuário um número para multiplicar com os valores do array
            Console.WriteLine("Agora digite um número para multiplicar o array: ");
            //Lendo e armazenando o número digitado
            int x = int.Parse(Console.ReadLine());
            
            //Declarando o array M com 10 índices
            int[] m = new int[10];

            //Repetir o processo até 9 -> a.length é o tamanho do vetor
            for (int i = 0; i <= a.Length - 1; i++)
            {
                //Armazendo valores no vetor M
                //No índice I do array M armazenamos o valor do vetor A no índice I vezes valor de X
                m[i] = a[i] * x;
                
                //Exibindo total no console
                Console.WriteLine(m[i]);
            }
        }
    }
}
