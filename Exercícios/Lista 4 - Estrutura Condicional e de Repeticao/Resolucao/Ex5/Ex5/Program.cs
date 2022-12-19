using System;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 5 - Lista 4

            Console.WriteLine("Digite a altura: ");
            //float.Parse() -> Converter string para float
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sexo: [F] ou [M]");
            //Console.ReadLine() -> Recebendo o que o usuário digitou
            string sexo = Console.ReadLine();

            //Declarando a variável mas não atribuindo nenhum valor
            double imc;

            if(sexo == "M")
            {
                //Se o sexo for igual a "M" calcular o IMC
                imc = ((72.7 * altura) - 58);
                //Exibir resultado no console
                //Math.Round() -> Arredonda o número em duas casas decimais
                Console.WriteLine("O IMC ideal é: " + Math.Round(imc, 2));
            } else if(sexo == "F")
            {
                //Se o sexo for igual a "F" calcular o IMC
                imc = ((62.1 * altura) - 44.7);
                //Exibindo resultado no console
                //Math.Round() -> Arredonda o número em duas casas decimais
                Console.WriteLine("O IMC ideal é: "+ Math.Round(imc, 2));
            } else
            {
                //O usuário não digitou corretamente
                Console.WriteLine("Sexo inválido");
            }
        }
    }
}
