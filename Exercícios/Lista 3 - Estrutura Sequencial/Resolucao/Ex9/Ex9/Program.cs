using System;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 9 - Lista 3

            //Equação de segundo grau:
            //delta = b2 - 4ac
            // x = -b +- raiz delta / 2a

            int a = 2;
            int b = 5;
            int c = 3;

            //Calculando o delta
            double delta = Math.Pow(b, 2) - 4 * a * c;
            
            //Esperado: 1
            Console.WriteLine("O resultado do delta é: "+ delta);
            
            //Armazenar a raiz quadrada do delta em uma variável
            double raiz = Math.Sqrt(delta);

            //Conferir se o delta é positivo ou não
            if(delta > 0)
            {
                //Se for positivo calcular as raizes
                double x = ((-(b)) + raiz) / (2 * a);
                double x2 = ((-(b)) - raiz) / (2 * a);

                //Escrever no console o resultado das duas raízes
                Console.WriteLine("A primeira raiz da equação é: " + x);
                Console.WriteLine("A segunda raiz da equação é: "+x2);
            } else {
                //Se não for positivo retornar mensagem
                Console.WriteLine("Delta deu negativo!");
            }
            


        }
    }
}
