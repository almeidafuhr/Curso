using System;

namespace Exercicios_expressoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um ano:");

            int convertedInput = Convert.ToInt32(Console.ReadLine());

            int modAnoQuatro = convertedInput % 4;
            int modAnoCem = convertedInput % 100;
            int modAnoQuatrocentos = convertedInput % 400;

			Console.Write("O ano é ")
            if(modAnoQuatrocentos == 0 || (modAnoQuatro == 0 && modAnoCem != 0))
            {
                Console.WriteLine("bissexto");
            }else
            {
                Console.WriteLine("bissexto");
            }
            Console.ReadLine();
        }
    }
}
