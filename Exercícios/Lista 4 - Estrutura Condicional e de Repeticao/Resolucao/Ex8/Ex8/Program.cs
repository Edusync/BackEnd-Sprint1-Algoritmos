using System;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 8 - Lista 4
            
            //Iremos repetir de 1 até 50
            for(int i = 1; i <= 50; i++)
            {
                //Verificando se o valor é múltiplo por 5
                //Armazenamos o valor do resto da divisão (%)
                float restoDivisao = i % 5;

                //Resto da divisão é igual zero
                if(restoDivisao == 0)
                {
                    //Condição verdadeira -> Escrever o valor que é múltiplo de 5
                    Console.WriteLine(i);
                }
            }
        }
    }
}
