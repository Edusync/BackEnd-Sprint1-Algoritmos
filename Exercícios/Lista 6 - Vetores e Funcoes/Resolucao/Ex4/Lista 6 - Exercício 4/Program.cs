using System;

namespace Lista_6___Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista 6 - Exercício 4

            //Declarando array com 5 índices
            string[] a = new string[4];

            //Repetição até 4    
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Digite um nome: ");
                //Armazenamos os valores digitados pelo usuário no array
                a[i] = Console.ReadLine();
            }

            //Armazenando o valor digitado pelo usuário para multiplicar
            Console.WriteLine("Digite um nome para procurar no array: ");
            string nomeProcurar = Console.ReadLine();

            //Variável para verificar se já foi achado
            int achou = 0;

            //Repete para cada valor dentro do array a
            foreach (string nomes in a)
            {
                //Se o nome que procuramos for igual ao nome do array
                if (nomeProcurar == nomes)
                {
                    //Se a condição for verdadeira mostramos que achamos
                    Console.WriteLine("ACHEI");
                    //Mudamos o número da váriavel
                    achou = 1;
                    //Saímos do foreach para não repetir se tiver mais nomes iguais
                    break;
                }
            }

            //Se a variável achou não mudou, ou seja, o nome não for achado
            if (achou == 0)
            { 
                //Mostramos que não achamos
                Console.WriteLine("NÃO ACHEI");
            }
        }
    }
}
