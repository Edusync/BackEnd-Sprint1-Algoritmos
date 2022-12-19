using System;

namespace Lista_6___Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando as variáveis
            int[] q = new int[10];
            int maiorPosicao = 0;
            int maiorValor = 0;
            int menorPosicao = 0;
            int menorValor = 0;

            //Repete 10 vezes -> Tamanho do vetor
            for(int i = 0; i < q.Length; i++)
            {
                //Usuário digita um número
                Console.WriteLine("Escreva um número: ");
                int valor = int.Parse(Console.ReadLine());

                //Enquanto o número digitado não for par
                while (valor % 2 != 0) {
                    //Perguntamos novamente e só saímos desse laço depois do número ser par
                    Console.WriteLine("Só aceitamos valores pares!");
                    Console.WriteLine("Escreva novamente um número: ");
                    valor = int.Parse(Console.ReadLine());
                }

                //Depois da validação podemos armazenar o valor digitado no array
                q[i] = valor;
            }

            for(int i = 0; i < q.Length; i++)
            {
                //Se for a primeira repetição armazenamos os valores iniciais nas variáveis
                if(i == 0)
                {
                    maiorValor = q[i];
                    menorValor = q[i];
                }
                
                //Se o menor número atual for maior do que o novo número
                if(menorValor > q[i])
                {
                    //Armazenamos seu valor na variável
                    menorValor = q[i];
                    //Armazenamos a posição do menor número
                    menorPosicao = i;
                }

                //Se o maior número atual for menor do que o novo número
                if(maiorValor < q[i])
                {
                    //Armazenamos o valor na variável
                    maiorValor = q[i];
                    //Armazenamos a posição do maior número
                    maiorPosicao = i;
                }
            }

            //Exibimos o resultado no console
            Console.WriteLine($"Maior número é {maiorValor} e sua posição é no vetor é: {maiorPosicao}");
            Console.WriteLine($"Maior número é {menorValor} e sua posição é no vetor é: {menorPosicao}");
        }
    }
}
