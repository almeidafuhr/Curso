using System;

namespace Exercicios_expressoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a idade de verificação");

            int idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite se você possui carteira (Sim ou Não)");

            string possuiCarteira = Console.ReadLine().ToLower();

            int maiorIdade = 18;

            if (idade >= maiorIdade && possuiCarteira.Equals("sim"))
                Console.WriteLine("Pode dirigir");
            else
                Console.WriteLine("Não pode dirigir");


            Console.ReadLine();

        }
    }
}
