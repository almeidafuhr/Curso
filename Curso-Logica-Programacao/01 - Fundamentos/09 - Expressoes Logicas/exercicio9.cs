using System;

namespace Exercicios_expressoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite 3 notas para calcular o status do aluno");

            Console.WriteLine("Digite a 1° nota");
            decimal primeiraNota = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a 2° nota");
            decimal segundaNota = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a 3° nota");
            decimal terceiraNota = Convert.ToDecimal(Console.ReadLine());

            decimal media = (primeiraNota + segundaNota + terceiraNota) / 3;

            int aprovado = 7;
            int minimoRecuperacao = 5;

            Console.Write("O aluno(a) está");
            if (media >= aprovado)
                Console.WriteLine(" aprovado.");
            else if(media < aprovado && media >= minimoRecuperacao)
                Console.WriteLine(" recuperação.");
            else
                Console.WriteLine(" reprovado.");


            Console.ReadLine();

        }
    }
}
