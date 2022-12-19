using System;

namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 14 - Lista 4

            //Declarando as variáveis
            int maiorNumero = 0;
            int menorNumero = 0;

            //Repetindo o processo 5 vezes
            for(int i = 0; i <= 4; i++)
            {
                //Pedindo para o usuário digitar um valor
                Console.WriteLine("Digite um valor: ");
                int valorA = int.Parse(Console.ReadLine());

                //Se for a primeira vez que o for está rodando
                if (i == 0)
                {
                    //Colocamos o mesmo valor para o maior e menor
                    maiorNumero = valorA;
                    menorNumero = valorA;
                }

                //O novo valor é maior que o número atual
                if(maiorNumero < valorA)
                {
                    //Condição verdadeira -> O novo valor agora é o maior número
                    maiorNumero = valorA;
                }

                //O novo valor é menor que o número atual
                if (menorNumero > valorA)
                {
                    //Condição verdadeira -> O novo valor agora é o menor
                    menorNumero = valorA;
                }
            }

            //Exibir o resultado no console
            Console.WriteLine("O maior valor é: "+ maiorNumero);
            Console.WriteLine("O menor valor é: "+ menorNumero);


        }
    }
}
