using System;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 2 - Lista 3

            //Atribuindo valores as váriaveis 
            //Usamos float porque a nota pode ter valores após a vírgula
            float nota1 = 7.5f;
            float nota2 = 10;
            float nota3 = 9.5f;

            //Calculando a média ponderada das notas
            //Cada nota tem um peso diferente
            float media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 3;

            //Exibindo o resultado no console
            //Math.round = Limita a exibir a nota com duas casas decimais
            Console.WriteLine("A média das notas é: "+ Math.Round(media, 2));

        }
    }
}
