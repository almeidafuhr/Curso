using System;

namespace Exercicios_expressoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número para validar se ele é par e positivo:");

            decimal numeroDigitadoPeloUsuario = Convert.ToInt64(Console.ReadLine());

            decimal modNumeroUsuario = numeroDigitadoPeloUsuario % 2;

            if (modNumeroUsuario == 0 && numeroDigitadoPeloUsuario > 0)
                Console.WriteLine("O número é par e maior que 0");
            else
                Console.WriteLine("O número não é par ou não é maior que 0");

            
            Console.ReadLine();

        }
    }
}
