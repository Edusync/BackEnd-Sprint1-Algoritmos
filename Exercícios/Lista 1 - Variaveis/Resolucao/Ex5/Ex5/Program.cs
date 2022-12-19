using System;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista 1 - Exercício 5

            //Declaração de variáveis
            int x = 12;

            //Variável Y recebe o valor de X
            int y = x;

            //Variável Z recebe o valor da soma
            int z = x + y;

            //Redefinindo os valoress de X e Y
            x = 20;
            y = 10;

            //Saída dos dados com concatenação de variáveis
            Console.WriteLine($"{x}, {y}, {z}");
        }
    }
}
