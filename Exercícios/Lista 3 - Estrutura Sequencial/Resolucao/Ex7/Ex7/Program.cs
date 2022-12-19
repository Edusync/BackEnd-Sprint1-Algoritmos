using System;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 7 - Lista 3

            //Total de eleitores e votos
            int totalEleitores = 1000;
            int votosBrancos = 200;
            int votosNulos = 100;
            int votosValidos = 700;

            //Percentual de votos brancos
            votosBrancos = (votosBrancos * (totalEleitores / 100)) / 100;

            //Percentual de votos nulos
            votosNulos = (votosNulos * (totalEleitores / 100)) / 100;

            //Percentual de votos válidos
            votosValidos = (votosValidos * (totalEleitores / 100)) / 100;

            //Exibir resultados no console
            Console.WriteLine("Percentual de votos brancos: "+ votosBrancos+"%");
            Console.WriteLine("Percentual de votos nulos: " + votosNulos + "%");
            Console.WriteLine("Percentual de votos válidos: " + votosValidos + "%");
        }
    }
}
