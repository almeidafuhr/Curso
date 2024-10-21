using System;

namespace Exercicios_expressoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma emperatura para converter em Frio, Agradavel ou Quente");

            int temperatura = Convert.ToInt16(Console.ReadLine());

            int frio = 10;
            int agradavel = 25;

            Console.Write("O clima está ");
            if (temperatura < frio)
                Console.WriteLine("frio");
            else if(temperatura >= frio && temperatura < agradavel)
                Console.WriteLine("agradavel");
            else
                Console.WriteLine("quente");


            Console.ReadLine();

        }
    }
}
