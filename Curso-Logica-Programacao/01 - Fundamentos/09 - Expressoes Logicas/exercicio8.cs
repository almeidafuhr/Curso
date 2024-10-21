using System;

namespace Exercicios_expressoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um caractere para verificar se é uma vogal");

            char possivelVogal = Convert.ToChar(Console.ReadLine());


            Console.Write("É uma ");
            if ('a'.Equals(possivelVogal) || 'e'.Equals(possivelVogal) ||
                'i'.Equals(possivelVogal) || 'o'.Equals(possivelVogal) || 'u'.Equals(possivelVogal))
                Console.WriteLine("vogal");
            else
                Console.WriteLine("não é vogal");



            Console.ReadLine();

        }
    }
}
