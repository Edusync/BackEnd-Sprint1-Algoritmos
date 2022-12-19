using System;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 6 - Lista 4

            Console.WriteLine("Digite o primeiro valor: ");
            //int.Parse() -> Converter string para int
            //Console.ReadLine() -> Armazena o que o usuário digita
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            //int.Parse() -> Converter string para int
            //Console.ReadLine() -> Armazena o que o usuário digita
            int num2 = int.Parse(Console.ReadLine());

            //Os dois números tem o mesmo valor
            if(num1 == num2)
            {
                //Condição verdadeira -> Os dois são iguais
                Console.WriteLine("Os dois números são iguais");

            //O primeiro número é maior que o segundo
            } else if(num1 > num2)
            {
                //Condição verdadeira -> O primeiro valor é maior
                Console.WriteLine("O primeiro valor é o maior");
            } else
            {
                //Condições anteriores falsas -> O segundo valor é o maior
                Console.WriteLine("O segundo valor é o maior");
            }
        }
    }
}
