using System;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 11 - Lista 3

            double distancia = 150; //km
            double velocidade = 65; //km/h

            //Calculando o tempo em horas
            double tempo = distancia / velocidade;

            //Convertendo horas para minutos
            tempo = tempo * 60;

            //Exibindo o resultado no console
            Console.WriteLine(tempo);
        }
    }
}
