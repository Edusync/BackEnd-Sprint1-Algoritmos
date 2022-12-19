using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando as variáveis
            int x = 10;
            int y = 12;

            //Variável Z recebe o valor de X
            int z = x;

            //Variável Y recebe o valor de Z 
            y = z;

            //Variável X recebe o valor de Y
            x = y;

            //Concatenando as variáveis
            Console.WriteLine($"{x}, {y}, {z}");
        }
    }
}
