using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1 - Lista 4

            Console.WriteLine("Digite a primeira nota: ");
            //O console.readline lê o que o usuário digitou
            //O float.Parse converte o que foi lido em string para float
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            //O console.readline lê o que o usuário digitou
            //O float.Parse converte o que foi lido em string para float
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            //O console.readline lê o que o usuário digitou
            //O float.Parse converte o que foi lido em string para float
            float nota3 = float.Parse(Console.ReadLine());

            //Calculando a média das notas
            float media = (nota1 + nota2 + nota3) / 3;

            //Se a média é maior ou igual a 6
            if(media >= 6)
            {
                //Se a condição do if for verdadeira o aluno foi aprovado
                Console.WriteLine("Aluno aprovado");
            } else
            {
                //Se a condição do if não for verdadeira o aluno foi reprovado
                Console.WriteLine("Aluno reprovado");
            }
        }
    }
}
