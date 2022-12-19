using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 3 - Lista 3

            //Atribuindo valor para a variável
            //Aqui temos o total de segundos em que o evento ocorreu
            int segundosTotal = 4830;

            //Primeiro convertemos os segundos totais para horas
            //1 hora = 3600 segundos
            int horasEvento = segundosTotal / 3600;

            //Depois pegamos o resto da divisão (%) das horas e convertemos para minutos
            //1 minutos = 60 segundos
            int minutosEvento = (segundosTotal % 3600) / 60;

            //Por último, o resto da divisão (%) vão se tornar os segundos 
            int segundosEvento = (segundosTotal % 3600) % 60;

            //Saída esperada :  1 hora 20 minutos e 30 segundos
            Console.WriteLine($"O evento ocorreu em: {horasEvento} hora(s) {minutosEvento} minuto(s) e {segundosEvento} segundo(s)");
        }
    }
}
