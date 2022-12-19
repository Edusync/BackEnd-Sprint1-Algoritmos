using System;

namespace Lista_6___Exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista 6 - Exercício 6

            //Declaração de variáveis
            //Declarando um vetor com 7 índices
            int[] temperaturas = new int[7];
            int menorTemp = 0;
            int maiorTemp = 0;
            int totalTemp = 0;
            int media;

            //Repetir 7 vezes
            for(int i = 0; i < temperaturas.Length; i++)
            {
                //Armazenando os valores que o usuário digita
                Console.WriteLine($"Digite a temperatura do dia {i + 1}: ");
                temperaturas[i] = int.Parse(Console.ReadLine());
            }

            //Repetir 7 vezes
            for(int i = 0; i < temperaturas.Length; i++)
            {
                //Se for a primeira vez da repetição
                if(i == 0)
                {
                    //Os dois vão receber a primeira temperatura
                    menorTemp = temperaturas[i];
                    maiorTemp = temperaturas[i];
                }

                //Se a próxima temperatura do array for maior que a temperatura atual
                if (maiorTemp < temperaturas[i])
                {
                    //Armazenar a maior temperatura na variável
                    maiorTemp = temperaturas[i];
                }

                // Se a próxima temperatura do array for menor que a temperatura atual
                if (menorTemp > temperaturas[i])
                {
                    //Armazenar a menor temperatura na variável
                    menorTemp = temperaturas[i];
                }

                //Somando os valores de todas as temperaturas
                totalTemp = totalTemp + temperaturas[i];
            }

            //Mostrando o resultado no console
            Console.WriteLine("Maior Temperatura: " + maiorTemp);
            Console.WriteLine("Menor Temperatura: " + menorTemp);

            //Calculando a média de temperatura
            media = totalTemp / 7;
            Console.WriteLine($"Média da semana: {media}");

            //Repetir isso 7 vezes
            for (int i = 0; i < temperaturas.Length; i++)
            {
               //Se a temperatura for menor do que a média da semana
                if (temperaturas[i] < media)
                {
                    //Escrever qual dia foi menor que a média
                    Console.WriteLine($"No dia {i + 1} a temperatura foi menor que a média");
                }
            }
        }
    }
}
