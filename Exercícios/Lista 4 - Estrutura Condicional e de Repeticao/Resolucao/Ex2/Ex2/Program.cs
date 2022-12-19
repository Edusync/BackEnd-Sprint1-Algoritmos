using System;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 2 - Lista 4

            Console.WriteLine("Digite o primeiro valor: ");
            //Console.ReadLine() -> Lê o que o usuário digitou
            //int.Parse() -> Converter a string em int
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            //Console.ReadLine() -> Lê o que o usuário digitou
            //int.Parse() -> Converter a string em int
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            //Console.ReadLine() -> Lê o que o usuário digitou
            //int.Parse() -> Converter a string em int
            int c = int.Parse(Console.ReadLine());

            //Agora vamos fazer a comparação dos valores

            //Se o primeiro valor for o maior
            if(a > b && a > c)
            {
                //Condição verdadeira -> Primeiro valor é o maior
                Console.WriteLine("O primeiro valor é o maior");
            } 
            //Se o primeiro valor não for o maior
            //Verificar se o segundo valor é o maior
            else if(b > c)
            {
                //Condição verdadeira -> Segundo valor é o maior
                Console.WriteLine("O segundo valor é o maior");
            }
            //Se o segundo valor não for o maior
            //Sobrou o terceiro para ser maior
            else
            {
                //Terceiro valor é o maior
                Console.WriteLine("O terceiro valor é o maior");
            }
        }
    }
}
