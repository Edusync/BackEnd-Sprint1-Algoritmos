using System;
using System.Linq;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 9 - Lista 4

            //Declaramos um array vazio
            int[] valoresDigitados = new int[5];

            //As variáveis começam zeradas
            int numeroUsuario = 0;
            int maiorNumero = 0;
            int contador = 0;

            //Repetimos o processo 5 vezes
            for(int i = 0; i < 5; i++)
            {
                //O usuário digita um novo valor para armazenar no vetor
                Console.WriteLine("Digite um valor: ");
                numeroUsuario = int.Parse(Console.ReadLine());

                //Armazenamos os valores digitados em um array 
                valoresDigitados[i] = numeroUsuario;
            }

            //Essa função retorna o maior número do array
            maiorNumero = valoresDigitados.Max();

            //Percorremos cada elemento do array
            foreach(int elementos in valoresDigitados)
            {
                //Se o elemento for igual ao maior número
                if(elementos == maiorNumero)
                {
                    //Se for verdadeiro adicionamos mais um na contagem de vezes que o elemento apareceu
                    contador = contador + 1;
                }
            }

            //Exibimos o resultado no console
            Console.WriteLine($"O maior número é {maiorNumero} e ele aparece {contador} vezes");
        }
    }
}
