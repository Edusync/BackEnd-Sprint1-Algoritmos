using System;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 12 - Lista 4

            //Úsuário insere um número
            Console.WriteLine("Digite um valor: ");
            int numero = int.Parse(Console.ReadLine());

            //O número é igual a um
            if(numero == 1)
            {
                //Condição verdadeira -> Saída "Domingo"
                Console.WriteLine("Domingo");
            }
            //O número é igual a dois
            else if (numero == 2)
            {
                //Condição verdadeira -> Saída "Segunda"
                Console.WriteLine("Segunda");
            }
            //O número é igual a três
            else if (numero == 3)
            {
                //Condição verdadeira -> Saída "Terça"
                Console.WriteLine("Terça");
            }
            //O número é igual a quatro
            else if (numero == 4)
            {
                //Condição verdadeira -> Saída "Quarta"
                Console.WriteLine("Quarta");
            }
            //O número é igual a cinco
            else if (numero == 5)
            {
                //Condição verdadeira -> Saída "Quinta"
                Console.WriteLine("Quinta");
            }
            //O número é igual a seis
            else if (numero == 6)
            {
                //Condição verdadeira -> Saída "Sexta"
                Console.WriteLine("Sexta");
            }
            //O número é igual a sete
            else if (numero == 7)
            {
                //Condição verdadeira -> Saída "Segunda"
                Console.WriteLine("Sábado");
            }
            //Nenhum dos números entrou nas condições
            else
            {
                //Se o número não estiver entre 1 e 7 ele é inválido
                Console.WriteLine("Número inválido");
            }
        }
    }
}
