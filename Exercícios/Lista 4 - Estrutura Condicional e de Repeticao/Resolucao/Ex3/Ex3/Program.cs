using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 3 - Lista 4

            Console.WriteLine("Digite um valor: ");
            //Console.ReadLine() -> Função para ler o que o usuário digitou
            //int.Parse() -> Converter string para int
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um segundo valor: ");
            //Console.ReadLine() -> Função para ler o que o usuário digitou
            //int.Parse() -> Converter string para int
            int b = int.Parse(Console.ReadLine());

            //Para verificar se são múltiplos o resto da divisão deve ser zero
            //A divisão deve ser o número maior dividido pelo número menor

            //Variável para armazenar o valor do resto da divisão
            float resto;

            //Garantindo que o número maior seja o dividendo
            if(a > b)
            {
                //% -> Coleta o resto da divisão dos dois números
                resto = a % b;
            } else
            {
                //% -> Coleta o resto da divisão dos dois números
                resto = b % a;
            }


            //Se o resto for igual a zero
            if(resto == 0)
            {
                //Os números são múltiplos
                Console.WriteLine("São múltiplos");
            } 
            
            //Se o resto não for igual a zero
            else{
                //Os números não são múltiplos
                Console.WriteLine("Não são múltiplos");
            }
        }
    }
}