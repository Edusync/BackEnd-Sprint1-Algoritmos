using System;

namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista 4 - Exercício 15

            //O que é a sequência de Fibonnaci?
            //Números em uma sequência onde o próximo número é formado pela soma dos valores  anteriores
            //Exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21 ...

            //Note: 0 + 1 = 1; 1 + 2 = 3; 3 + 5 = 8;

            //Primeiro número da sequência
            int primeiroNumero = 0;
            //Segundo número da sequência
            int segundoNumero = 1;
            //Variável temporária -> Armazena um valor para salvar um valor por um curto período de tempo
            int auxiliar = 0;


            //Repetir o processo 15 vezes
            for(int i = 0; i < 15; i++)
            {
                //Primeiro escrevemos o número da primeira posição
                Console.WriteLine(primeiroNumero);

                //O valor dentro do primeiro número é armazenado na variável auxiliar
                //Assim o valor não se perde e vamos poder somar depois
                auxiliar = primeiroNumero;

                //O primeiro número recebe o valor do segundo número
                primeiroNumero = segundoNumero;

                //O segundo número é o valor da nossa nova posição
                //Uma nova posição é composta por uma soma entre o auxiliar e o primeiro número
                segundoNumero = auxiliar + primeiroNumero;
                
            }
        }
    }
}
