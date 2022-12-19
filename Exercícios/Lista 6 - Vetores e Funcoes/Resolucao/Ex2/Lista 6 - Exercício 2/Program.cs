using System;

namespace Lista_6___Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista 6 - Exercício 2

            //Declarando o vetor V com todos os valores dentro dele
            int[] v = new int[8] {5, 1, 4, 2, 7, 8, 3, 6 };
            //Declarando o vetor V2 vazio
            int[] v2 = new int[8];

            //Repetir 8 vezes -> v.Length é o tamanho do vetor
            for (int i = 0; i < v.Length; i++)
            {
                //Agora adicionamos valores no vetor v2
                //O índice i do v2 recebe o dobro (vezes dois) o valor do vetor v no índice i
                v2[i] = v[i] * 2; 
                //Mostrar resultado no console
                Console.WriteLine($"No índice {i} do vetor v2 temos o valor {v2[i]}");
            }
        }
    }
}
